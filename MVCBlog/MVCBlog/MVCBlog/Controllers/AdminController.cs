using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCBlog.Data.Interfaces;
using MVCBlog.Models;
using MVCBlog.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBlog.Controllers
{
    public class AdminController : Controller
    {

        //private IPostRepository _postRep;
        //public AdminController(IPostRepository postRep)
        //{
        //    _postRep = postRep;
        //}
        //public IActionResult Admin()
        //{
        //    return View();
        //}
        //public IActionResult PostEditor(int postID)
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ViewResult CreatePost()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CreatePost(BlogModel post)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    return View();
        //}
        //}
        public class AccountController : Controller
        {
            private readonly UserManager<IdentityUser> userManager;
            private readonly SignInManager<IdentityUser> signInManager;

            public AccountController(UserManager<IdentityUser> userManager,
                SignInManager<IdentityUser> signInManager)
            {
                this.userManager = userManager;
                this.signInManager = signInManager;

            }

            [HttpGet]
            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Register(RegisterViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Blog", "Blog");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return View(model);
            }
        }
    }
}
