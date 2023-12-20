﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;
using MoviesWebApi.Data.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Controllers
{
    [Route("api/auth")]
    //[Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly string secretKey;
        private readonly ApiResponse apiResponse;
        private readonly UserManager<ApplicationUser> userManager;   

        public AuthController(
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager)
        {
            this.secretKey = configuration.GetValue<string>("JWT:Secret");
            this.apiResponse = new ApiResponse();
            this.userManager = userManager;         
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages = new List<string>() { InvalidState };
                return this.BadRequest(this.apiResponse);
            }

            ApplicationUser newUser = new ApplicationUser()
            {
                UserName = registerDto.Username,
                Email = registerDto.Email,
            };

            IdentityResult result = await this.userManager.CreateAsync(newUser, registerDto.Password);

            if (result.Succeeded)
            {
                await this.userManager.AddToRoleAsync(newUser, UserRoleName);
                this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                this.apiResponse.Result = newUser;
                return this.Ok(this.apiResponse);
            }

            this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
            this.apiResponse.IsSuccess = false;
            this.apiResponse.ErrorMessages.Add(RegisterError);

            foreach (IdentityError error in result.Errors)
            {
                //this.ModelState.AddModelError(string.Empty, error.Description);
                this.apiResponse.ErrorMessages.Add(error.Description);
            }

            return this.BadRequest(this.apiResponse);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            if(!this.ModelState.IsValid)
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages = new List<string>() { InvalidState };
                return this.BadRequest(this.apiResponse);
            }
            ApplicationUser user = await this.userManager.FindByNameAsync(loginDto.Username);

            if (user != null)
            {
                bool isValid = await this.userManager.CheckPasswordAsync(user, loginDto.Password);
                if(!isValid)
                {
                    this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                    this.apiResponse.IsSuccess = false;
                    this.apiResponse.ErrorMessages.Add(LoginError);
                    return this.BadRequest(this.apiResponse);
                }

                IList<string> roles = await this.userManager.GetRolesAsync(user);
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                byte[] key = Encoding.ASCII.GetBytes(this.secretKey);

                SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor()
                {
                    //Here we add the properties we want to add in the token
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("id", user.Id),
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, roles.FirstOrDefault())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
                string tokenAsString = tokenHandler.WriteToken(token);

                this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                this.apiResponse.IsSuccess = true;
                this.apiResponse.Result = new { id = user.Id, username = user.UserName, email = user.Email, token = tokenAsString };
                return this.Ok(this.apiResponse);

            }
            else
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages.Add(LoginError);
                return this.BadRequest(this.apiResponse);
            }

        }
    }
}