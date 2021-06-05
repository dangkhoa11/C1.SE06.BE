using RETP.app.System.User;
using RETP.ViewModels.System.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RETP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService1 _userService;
        public UserController(IUserService1 userService)
        {
            _userService = userService;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] loginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var resultToken = await _userService.Authencate(request);
            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest("User or password is incorrect");
            }
            return Ok( "Đăng Nhập Thành Công" );

        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] registerRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _userService.Register(request);
            if (!result)
            {
                return BadRequest("Register is unsuccessful");
            }
            return Ok("Register successful");
        }
        
    }
}
