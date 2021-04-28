using DotNetOpenAuth.InfoCard;
using login.data.entities;
using login.ViewModels.System.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace login.app.System.User
{
    public class UserService : IUserService1
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration config)
        {
            
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }
        //public async Task<string> Authencate(loginRequest request)
        //{
        //    var user =await _userManager.FindByNameAsync(request.userName);
        //    if (user == null) return null;
        //    var result = await _signInManager.PasswordSignInAsync(request.userName, request.password, request.rememberMe, true);
        //    if (!result.Succeeded)
        //    {
        //        return null;
        //    }
        //    var roles =await _userManager.GetRolesAsync(user); 
        //    var claims = new[]
        //    {
        //        new Claim(ClaimTypes.Email ,user.UserName),
        //        new Claim(ClaimTypes.GivenName,user.Firstname),
        //        new Claim(ClaimTypes.Role,string.Join(";",roles))
        //    };
        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Token:Key"]));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //    var token = new JwtSecurityToken(_config["Token:Issuer"],
        //        _config["Token:Issuer"],
        //        claims,
        //        expires: DateTime.Now.AddHours(3),
        //        signingCredentials: creds);
        //    return new JwtSecurityTokenHandler().WriteToken(token);
                
            
        //}

        public async Task<bool> Register(registerRequest request)
        {
            var user = new AppUser()
            {
                UserName = request.userName,
                Firstname = request.firstName,
                Lastname = request.lastName,
                PhoneNumber = request.phoneNumber,
                Email = request.Email
            };
            var result = await _userManager.CreateAsync(user, request.password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
            
        }

        
    }

    
}
