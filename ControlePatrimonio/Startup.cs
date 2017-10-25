using ControlePatrimonio.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlePatrimonio.Startup))]
namespace ControlePatrimonio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        // In this method we will create default User roles and Admin user for login  
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            //In Startup I am creating first Admin Role and creating a default Admin User
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin role   
                var role1 = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role1.Name = "Admin";
                roleManager.Create(role1);

                //Here we create a Admin super user who will maintain the website                 

                var user = new ApplicationUser();
                user.UserName = "lamar2020";
                user.Email = "lamar.jackson@nfl.com";

                string userPWD = "123456";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin  
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            //creating Creating Manager role
            if (!roleManager.RoleExists("manager"))
            {
                var role2 = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role2.Name = "manager";
                roleManager.Create(role2);

            }

            //creating Creating Employee role
            if (!roleManager.RoleExists("employee"))
            {
                var role3 = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role3.Name = "employee";
                roleManager.Create(role3);

            }
        }
    }
}
