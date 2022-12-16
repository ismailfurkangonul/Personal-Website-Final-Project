using AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Configuration;
using AriBilgi.IsmailFurkan.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Contexts
{
    public class IsmailFurkanContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Certificates> Certificatess { get; set; }     
        public DbSet<Education> Educations { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-4R8CEG0J\\SQLEXPRESS;Database=bitirmeprojesi;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new CertificatesConfiguration());
            modelBuilder.ApplyConfiguration(new EducationConfiguration());


            base.OnModelCreating(modelBuilder);

        }
    }
}
