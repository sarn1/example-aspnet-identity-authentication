﻿using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly:OwinStartupAttribute(typeof(IdentityFromScratch.StartUp))]
namespace IdentityFromScratch
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {

        }

    }
}