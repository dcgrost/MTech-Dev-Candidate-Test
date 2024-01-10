using Microsoft.AspNetCore.Mvc;
using UserController.Models;
using UserController.Services;
using System.Collections.Generic;

namespace UserController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> ListUser()
        {
            return _userService.ListUsers();
        }
    }
}
