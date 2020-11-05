using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StarexFinal.Models;
using StarexFinal.ViewModels;
using StarexFinalProject.ViewModel;

namespace StarexFinalProject.Controllers
{
    public class AccountController : Controller

    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpPost]
        public IActionResult Register(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
               
            }
            return View();
        }
    }
}
