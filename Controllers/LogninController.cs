using loginApp.Models;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace loginApp.Controllers
{
    public class LoginController: Controller
    {

        public readonly SignInManager<IdentityUser> _signInUser ;
        public LoginController( SignInManager<IdentityUser> _signInUser)
        {
            this._signInUser = _signInUser;
        }
        
        [HttpPost]
        
        public async Task<IActionResult> onLogin(loginModel login)
        {
          
            if (ModelState.IsValid)
            {
                
                    var IdentityResult=await _signInUser.PasswordSignInAsync(login.email,login.Password,login.rememberme,false);
                    if(IdentityResult.Succeeded)
                    {
                        
                    return RedirectToAction("Index","Home");
                    }
                  
                      TempData["invalidAttempt"] = "error";
            }
                 
            return  RedirectToAction("login","Home",login);
        }
            
            
    }
}
