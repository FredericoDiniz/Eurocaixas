using Eurocaixas.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Eurocaixas.Data.Context
{
    public class EurocaixasDBContext : DbContext
    {
        public EurocaixasDBContext() : base("EurocaixasDBContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<SystemPermission> SystemPermissions { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Properties<string>().Where(p => p.Name.Contains("Description")).Configure(p => p.HasMaxLength(400));

            modelBuilder.Properties<string>().Where(p => p.Name.Equals("State")).Configure(p => p.HasMaxLength(2));


            base.OnModelCreating(modelBuilder);
        }
    }   
}
