using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Template.Models;


namespace WelcomeHomeWeb.Repositories
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {

        public DataContext() : base("DefaultConnection", throwIfV1Schema: false) { }

        public static DataContext Create() => new DataContext();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
