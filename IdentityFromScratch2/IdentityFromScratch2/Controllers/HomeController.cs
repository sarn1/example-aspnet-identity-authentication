using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using IdentityFromScratch2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using static IdentityFromScratch2.Models.ApplicationDbContext;

namespace IdentityFromScratch2.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {

            // these var, to keep it dry, you could put this in a base controller and inherit from it, but the best is to use OwinContext.

            var context = new ApplicationDbContext(); // will look for DefaultConnection - see IdentityModels.cs
            var store = new UserStore<CustomUser>(context);
            var manager = new UserManager<IdentityUser>(store);

            // the string represents the guid data type which is a string in the db
            var signInManager = new SignInManager<CustomUser,string>(manager,HttpContext.GetOwinContext().Authentication);

        
            var email = "foo@bar.com";
            var password = "Passw0rd";

            // find if not then create.
            var user = await manager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new CustomUser
                {
                    UserName = email,
                    Email = email,
                    firstname = "Super",
                    lastname = "Admin"

                    // no password here
                }; // by creating the user here as an obj, you havn't really created the user

                await manager.CreateAsync(user, password);
            } else
            {
                // else user exists so login the user....
                var result = await signInManager.PasswordSignInAsync(user.UserName, password, true, false);
                if (result == SignInStatus.Success)
                {
                    return Content("hello" + user.firstname);
                }
            }


            return Content("Hello, Index");

            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}