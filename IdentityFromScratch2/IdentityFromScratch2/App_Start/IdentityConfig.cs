using IdentityFromScratch2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static IdentityFromScratch2.Models.ApplicationDbContext;

namespace IdentityFromScratch2.App_Start
{
    public class ApplicationUSerManager:UserManager<CustomUser>
    {
        public ApplicationUSerManager(UserStore<CustomUser> userStore) : base(userStore) { }
        
        public static ApplicationUSerManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var userStore = new UserStore<CustomUser>(context.Get<ApplicationDbContext>());

            return new ApplicationUSerManager(userStore);
        }
        // IUSer - the user
        // IdentityUser - use as-is or customize by inheriting from this
        // IIuserStore<>  - a way to store user
        // UserStore<IdentityUser>
        // Usermanager - obj that uses the userstore to manage users (CRUD)
        // example, you pass an iuser to usermanager to CRUD IIuserstore
        // SignInManager<> - asp.net identity owin namespace, while all the above is aspnet identity namespace

        //IdentityDbContext<IdentityUser>

        public class ApplicationSignInManager : ApplicationSignInManager<CustomUser, String>
        {
            public ApplicationSignInManager(ApplicationUSerManager userManager,
                IAuthenticationManager authenticationManager) : base(userManager, authenticationManager) { }
        }


        // left off on 3.4 10:30

    }
}