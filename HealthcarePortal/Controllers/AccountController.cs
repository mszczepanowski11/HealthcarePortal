using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthcarePortal.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private SignManager<IdentityUser> -signManager;

        public AccountController(UserManager<IdentityUser> userManager,SignManager<IdentityUser> signManager)
        {
            _userManager = userManager;
            _signManager = signManager;
        }

        [AllowAnonymous]
        [HttpGet]

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            }); 
        }
    }
}

