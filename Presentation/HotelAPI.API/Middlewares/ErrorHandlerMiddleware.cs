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
        private  IApplicationErrorRepository _errorRepository;
        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            
            _next = next;
           

        }
        public async Task Invoke(HttpContext context, IApplicationErrorRepository repository)
        {
            try
            {
                _errorRepository = repository;
                await _next(context);

            }
            catch (Exception ex)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var msg = new { Message = ex.Message, StatusCode = response.StatusCode, Type = ex.Source };
                var result = JsonSerializer.Serialize(msg);
                await  _errorRepository.CreateAsync(new ApplicationError() { ErrorMessage = ex.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
