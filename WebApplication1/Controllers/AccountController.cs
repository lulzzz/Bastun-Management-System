﻿namespace BMS.Controllers
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
        public async Task<IActionResult> Register(UserInputModel userInputModel)
        {
            if (!this.ModelState.IsValid)
            {
               return this.View("Index", userInputModel);
            } 
            else
            {
                if (userInputModel.ConfirmPassword == userInputModel.Password)
                {
                    var user = this.mapper.Map<IdentityUser>(userInputModel);

                    var result = await this.userManager.CreateAsync(user, userInputModel.Password);

                    if (!result.Succeeded)
                    {
                        return this.RedirectToAction("Index", "Home");
                    }
                }
           

                return this.RedirectToAction("Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserInputModel loginUserInputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction("Index", "Home");
            }

            var userId = userManager.GetUserId(HttpContext.User);
            var userData = await userManager.FindByIdAsync(userId);

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

            return this.RedirectToAction("Index", "Home");
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
