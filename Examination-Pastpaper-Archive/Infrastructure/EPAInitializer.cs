using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Examination_Pastpaper_Archive.Infrastructure
{
    public class EPAInitializer : DropCreateDatabaseIfModelChanges<EPAContext>  //DropCreateDatabaseAlways //DropCreateDatabaseIfModelChanges
    {
        protected override void Seed(EPAContext context)
        {
            var hasher = new PasswordHasher();
            var user = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            user.UserValidator = new UserValidator<ApplicationUser>(user) { AllowOnlyAlphanumericUserNames = false };
            user.Create(new ApplicationUser()
            {
                UserName = "SuperPowerUser",
                Email = "taiseer.joudeh@mymail.com",
                EmailConfirmed = true,
                FirstName = "Taiseer",
                LastName = "Joudeh",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3)
            });
        }
    }
}