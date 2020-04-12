namespace BMS.Controllers
{
    using AutoMapper;
    using BMS.Models;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using System.Web.Providers.Entities;

    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(IMapper mapper, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserInputModel userInputModel)
        {
            if (!this.ModelState.IsValid)
            {
               return this.View("_WelcomePartial", userInputModel);
            } 
            else
            {
                var user = this.mapper.Map<IdentityUser>(userInputModel);

                var result = await this.userManager.CreateAsync(user, userInputModel.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        this.ModelState.AddModelError("Username", "Username is invalid!");
                    }

                    return this.View("_WelcomePartial", userInputModel);
                }

             

                return this.RedirectToAction("RegisterFlight", "Flights");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserInputModel loginUserInputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("_WelcomePartial", loginUserInputModel);
            }

            var user = await this.userManager.FindByNameAsync(loginUserInputModel.UserName);

            if (user != null && await this.userManager.CheckPasswordAsync(user, loginUserInputModel.Password))
            {
                var identity = new ClaimsIdentity(IdentityConstants.ApplicationScheme);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));

               var result = await this.signInManager.PasswordSignInAsync(user, loginUserInputModel.Password, loginUserInputModel.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return this.RedirectToAction("Index", "Home");
                }
            }

            return this.View("_WelcomePartial", loginUserInputModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {

            await this.signInManager.SignOutAsync();

            return this.RedirectToAction("Index", "Home");
        }
    }
}
