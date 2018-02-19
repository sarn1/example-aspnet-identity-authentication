using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityFromScratch2.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {

            var context = new IdentityDbContext<IdentityUser>(); // will look for DefaultConnection
            var store = new UserStore<IdentityUser>(context);
            var manager = new UserManager<IdentityUser>(store);

            var email = "foo@bar.com";
            var password = "Passw0rd";

            // find if not then create.
            var user = await manager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new IdentityUser
                {
                    UserName = email,
                    Email = email

                    // no password here
                }; // by creating the user here as an obj, you havn't really created the user

                await manager.CreateAsync(user, password);
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