using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace loginApp.Controllers
{
    public class LogoutController:Controller
    {
          public readonly SignInManager<IdentityUser> _signInUser ;
        public LogoutController( SignInManager<IdentityUser> _signInUser)
        {
            this._signInUser = _signInUser;
        }
        
       
        public async Task<IActionResult> Logout()
        {
         await _signInUser.SignOutAsync();
         return  RedirectToAction("login","Home");
        }

        public  IActionResult dontLogout()
        {
             return  RedirectToAction("Index","Home");
        }
    }
}