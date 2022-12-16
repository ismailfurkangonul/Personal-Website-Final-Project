using AriBilgi.IsmailFurkan.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Configuration
{
    public class CertificatesConfiguration : IEntityTypeConfiguration<Certificates>
    {
        public void Configure(EntityTypeBuilder<Certificates> builder)
        {
            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Title).HasMaxLength(70);

            

            builder.HasData(new Certificates
            {
                Id = 1,
                Title = "Certificates",
                Certificate1 = "2020 Yılı EuroPass Sertifikası",
                Certificate2 = "2022 Yılı (HackerRank) C# Sertifikası",
                Certificate3 = "2022 Yılı (Bilgeİş) HTML Sertifikası",
                Certificate4= "2022 Yılı (Bilgeİş) CSS Sertifikası",
                Certificate5= "2022 Yılı (HackerRank) SQL Sertifikası",
                CreatedBy = 1,
                CreatedDate = DateTime.Now
            });

        }
    }
}
