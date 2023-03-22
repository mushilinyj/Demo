using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DemoCore.Controllers
{
    public class LoginController : BaseController
    {
        [HttpPost]
        [Route("/login")]
        public IResult Login()
        {
            return Results.Challenge(new Microsoft.AspNetCore.Authentication.AuthenticationProperties() {
                RedirectUri = "https://localhost:44325"
            },authenticationSchemes: new List<string>() { "custom" });

            //return new APIReturn();
        }
        //[HttpPost]
        //[Route("/")]
        //public IResult Index()
        //{
        //    return this.HttpContext.User.Claims.Select(x => new { x.Type, x.Value }).ToList();
        //}
    }
}
