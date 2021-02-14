﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _userService.GetALL();
            if (result.succces)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.message);
        }

     
        [HttpPost("adduser")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.succces)
            {
                return Ok(result.message);
            }

            return BadRequest(result.message);
        }

    }
}