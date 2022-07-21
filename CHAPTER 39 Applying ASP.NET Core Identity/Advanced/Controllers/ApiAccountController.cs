﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
namespace Advanced.Controllers
{
    [ApiController]
    [Route("/api/account")]
    public class ApiAccountController : ControllerBase
    {
        private SignInManager<IdentityUser> signinManager;
        public ApiAccountController(SignInManager<IdentityUser> mgr)
        {
            signinManager = mgr;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Credentials creds)
        {
            Microsoft.AspNetCore.Identity.SignInResult result
            = await signinManager.PasswordSignInAsync(creds.Username,
            creds.Password, false, false);
            if (result.Succeeded)
            {
                return Ok();
            }
            return Unauthorized();
        }
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await signinManager.SignOutAsync();
            return Ok();
        }
        public class Credentials
        {
            [Required]
            public string Username { get; set; }
            [Required]
            public string Password { get; set; }
        }
    }
}