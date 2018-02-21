﻿using IdentityFromScratch2.Models;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(IdentityFromScratch2.Startup))]
namespace IdentityFromScratch2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext(ApplicationUserManager.Create);
        }

}
}