using DemoCore.AutoModule;
using DemoCore.DTO;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DemoCore.IServiceHelper
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(LoginRequestDTO request, out string token);
    }

    public class AuthenticateService : IAuthenticateService
    {
        private readonly JwtManagement jwt;
        public AuthenticateService(JwtManagement jwtManagement) 
        {
            this.jwt = jwtManagement;
        
        }
        public bool IsAuthenticated(LoginRequestDTO request, out string token)
        {
            token = string.Empty;
            var claims = new[] {
                new Claim(ClaimTypes.Name,request.UserName),
                new Claim("PassWord",request.PassWord),
                new Claim(ClaimTypes.Role,"Admin")
           };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Secret));
            var creidentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwttoken = new JwtSecurityToken(
                jwt.Issuer, 
                jwt.Audience, 
                claims: claims,
                expires: DateTime.Now.AddDays(jwt.AccessExpiration),
                signingCredentials: creidentials
                );
            token = new JwtSecurityTokenHandler().WriteToken(jwttoken);
            return true;
        }
    }
}
