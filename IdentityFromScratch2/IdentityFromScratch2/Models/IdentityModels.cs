using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityFromScratch2.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext() : base()
        {

        }

        public class CustomUser : IdentityUser
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
        }
    }
}