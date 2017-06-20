using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Template.Models;


namespace Template.Web
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {

        public Member Member { get; set; }


        public DataContext() : base("DefaultConnection", throwIfV1Schema: false) { }

        public static DataContext Create() => new DataContext();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasOptional(t => t.Member)
                .WithRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
