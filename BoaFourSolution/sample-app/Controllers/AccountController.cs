using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Controllers
{
   //[Route("Account")]
    public class AccountController : Controller
    {
        [Route("Login")]
        [Route("Login/{username:minlength(4)}/{password:minlength(4)}")]
        public IActionResult Login(string userName,string password)
        {
            return Content("Login Called");
        }

       // [Route("Logout")]
        public IActionResult Logout()
        {
            return Content("Logout Called");
        }
        [Route("Register")]
        public IActionResult Register()
        {
            return Content("Register Called");
        }
    }
}
