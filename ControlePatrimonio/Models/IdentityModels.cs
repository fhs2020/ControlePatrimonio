using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ControlePatrimonio.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string Region { get; set; }

        public string UsuarioPerfil { get; set; }

        public int FilialId { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<ControlePatrimonio.Models.Empresa> Empresas { get; set; }

        public System.Data.Entity.DbSet<ControlePatrimonio.Models.Filial> Filials { get; set; }

        public System.Data.Entity.DbSet<ControlePatrimonio.Models.Fornecedor> Fornecedors { get; set; }

        public System.Data.Entity.DbSet<ControlePatrimonio.Models.Produto> Produtoes { get; set; }

        public System.Data.Entity.DbSet<ControlePatrimonio.Models.Patrimonio> Patrimonios { get; set; }
    }
}