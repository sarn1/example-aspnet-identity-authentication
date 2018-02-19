# Authentication With ASP.NET Identity #

User authentication and authorization are mandatory components of nearly every web application. You could always roll your own solution, but that's not considered best practice. It is too easy to introduce a security flaw into your system that could lead to compromised user data. Instead, it's better to use a robust existing authentication and authorization library.

This course will teach you how to use Microsoft's Identity framework—a complete user authentication and authorization system for ASP.NET applications.

https://code.tutsplus.com/courses/authentication-with-aspnet-identity

## 2.1 ##
- Identity is basically OWIN middleware.  `Startup.cs`
	- Logging would be put here.
- `App_Start/Startup.Auth.cs` more OWIN here.  See more notes there,.
- More notes in `App_start/IdentityConfig.cs` like changing password options, spceial characters in username, email service, etc..
- `Controller/AccountController.cs` in login, the password is not hashed, that is done internally.

## 2.2 Identity From Scratch Or For Existing Project Without Identity ##
- Simulates a project that didn't have Identity.  New project > empty MVC.
- Must install from Nuget: `Microsoft.Owin.Host.SystemWeb`, `Microsoft.Owin.Security.OAuth`, `Microsoft.Owin.Security.OAuth`, `Microsoft.Owin.Security.Cookies`, `Microsoft.AspNet.Identity.Core`, `Microsoft.AspNet.Identity.Owin`, `Microsoft.AspNet.Identiy.EntityFramework`
- You will get this error when compiling.  If you got versioning issue errors, then you need to edit your config files since Nuget messed up.
![Image of Error](https://octodex.github.com/images/yaktocat.png)

```csharp
// StartUp.cs

using Microsoft.Owin;
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

```

## 2.3 Creating the Necessary Objects ##

```csharp
// General Notes

        // IUSer - the user
            // IdentityUser - use as-is or customize by inheriting from this
        // IIuserStore<>  - a way to store user
            // UserStore<IdentityUser>
        // Usermanager - obj that uses the userstore to manage users (CRUD)
            // example, you pass an iuser to usermanager to CRUD IIuserstore
        // SignInManager<> - asp.net identity owin namespace, while all the above is aspnet identity namespace

        //IdentityDbContext<IdentityUser>

```

