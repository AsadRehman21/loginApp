using loginApp.Models;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace loginApp.Controllers
{
    public class RegisterController: Controller
    {
        public readonly UserManager<IdentityUser> _userManager;
        public readonly SignInManager<IdentityUser> _signInUser ;
        public RegisterController(UserManager<IdentityUser> _userManager, SignInManager<IdentityUser> _signInUser)
        {
            this._signInUser = _signInUser;
            this._userManager = _userManager;
        }
        
        [HttpPost]
        public async Task<IActionResult> onPost(RegisterModel register)
        {
          
            if (ModelState.IsValid)
            {
                
                var user= new IdentityUser
                {
                    UserName = register.email,
                    Email= register.email
                };
                var result = await _userManager.CreateAsync(user,register.Password);
                if(result.Succeeded)
                {
                    await _signInUser.SignInAsync(user,false);
                    
                    return RedirectToAction("Index","Home");
                }
                foreach(var error in result.Errors)
                {
                  ModelState.AddModelError("",error.Description);
                }
            }
            
            return RedirectToAction("register","Home",register);
        }
    }
}