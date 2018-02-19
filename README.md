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



