using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System.Net;
using System.Text.Json;

namespace HotelAPI.API.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private  ITestRepository _errorRepository;
        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            
            _next = next;
           

        }
        public async Task Invoke(HttpContext context, ITestRepository repository)
        {
            try
            {
                _errorRepository = repository;
                await _next(context);
                //await _errorRepository.CreateAsync(new TestError() { ErrorMessage = "altay"});

            }
            catch (Exception ex)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var msg = new { Message = ex.Message, StatusCode = response.StatusCode, Type = ex.Source };
                var result = JsonSerializer.Serialize(msg);
                await  _errorRepository.CreateAsync(new TestError() { ErrorMessage = ex.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
