using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityFromScratch2.App_Start
{
    public class IdentityConfig
    {
        
        // IUSer - the user
            // IdentityUser - use as-is or customize by inheriting from this
        // IIuserStore<>  - a way to store user
            // UserStore<IdentityUser>
        // Usermanager - obj that uses the userstore to manage users (CRUD)
            // example, you pass an iuser to usermanager to CRUD IIuserstore
        // SignInManager<> - asp.net identity owin namespace, while all the above is aspnet identity namespace

        //IdentityDbContext<IdentityUser>
    }
}