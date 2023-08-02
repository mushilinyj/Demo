using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;

namespace DemoCore.AuthorizationHelper
{
    public class MyTokenValidator : ISecurityTokenValidator
    {
        public bool CanValidateToken => true;

        public int MaximumTokenSizeInBytes { get; set; }

        public bool CanReadToken(string securityToken) => true;
       

        public ClaimsPrincipal ValidateToken(string securityToken, TokenValidationParameters validationParameters, out SecurityToken validatedToken)
        {
            //string jwtToken = AESCryptoHelper.Decrypt(securityToken);
           
            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(securityToken, validationParameters, out validatedToken);

            return principal;
        }
    }
}
