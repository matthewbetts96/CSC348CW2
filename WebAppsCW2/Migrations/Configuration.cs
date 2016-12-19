namespace WebAppsCW2.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppsCW2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppsCW2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppsCW2.Models.ApplicationDbContext context)
        {
            makeRoles(context);
            AddUser(context);
            AddLecturer(context); 
        }
        
        void AddUser(WebAppsCW2.Models.ApplicationDbContext context)
        {
            var User = new ApplicationUser { UserName = "Student1@email.com" };
            var usr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            usr.Create(User, "password");

            var User2 = new ApplicationUser { UserName = "Student2@email.com" };
            var usr2 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            usr2.Create(User2, "password");

            var User3 = new ApplicationUser { UserName = "Student3@email.com" };
            var usr3 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            usr3.Create(User3, "password");

            var User4 = new ApplicationUser { UserName = "Student4@email.com" };
            var usr4 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            usr4.Create(User4, "password");

            var User5 = new ApplicationUser { UserName = "Student5@email.com" };
            var usr5 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            usr5.Create(User5, "password");

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var Stu1 = UserManager.FindByName("Student1@email.com");
            usr.AddToRole(Stu1.Id, "Student");
            var Stu2 = UserManager.FindByName("Student2@email.com");
            usr2.AddToRole(Stu2.Id, "Student");
            var Stu3 = UserManager.FindByName("Student3@email.com");
            usr3.AddToRole(Stu3.Id, "Student");
            var Stu4 = UserManager.FindByName("Student4@email.com");
            usr4.AddToRole(Stu4.Id, "Student");
            var Stu5 = UserManager.FindByName("Student5@email.com");
            usr5.AddToRole(Stu5.Id, "Student");    
            
        }
        void AddLecturer(WebAppsCW2.Models.ApplicationDbContext context)
        {
            var Lec1 = new ApplicationUser { UserName = "Lecturer1@email.com" };
            var Lc1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            Lc1.Create(Lec1, "password");
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var Lect1 = UserManager.FindByName("Lecturer1@email.com");
            Lc1.AddToRole(Lect1.Id, "Lecturer");
        }

        void makeRoles(WebAppsCW2.Models.ApplicationDbContext context)
        {
            context.Roles.AddOrUpdate(n => n.Name,
                new IdentityRole { Name = "Student" },
                new IdentityRole { Name = "Lecturer" });
        }
    }
}
