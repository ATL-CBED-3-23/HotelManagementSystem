﻿using HotelAPI.Application.DTOs.Reviews;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReviewAPI.API.Controllers.Review
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin_and_Staff_and_User)]

    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

       
    }
}
