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
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.Property(e => e.Title).IsRequired();
            builder.Property(e => e.Title).HasMaxLength(70);

            builder.Property(e => e.Schoolname1).HasMaxLength(500);
            builder.Property(e => e.Schoolsubtitle1).HasMaxLength(500);
            builder.Property(e => e.Schoolname2).HasMaxLength(500);
            builder.Property(e => e.Schoolsubtitle2).HasMaxLength(500);

            builder.HasData(new Education
            {
                Id = 1,
                Title = "Eğitim",
                Schoolname1 = "Üsküdar Lisesi",
                Schoolsubtitle1 = "Meslek Lisesi",
                Schoolname2 = "Beykoz Üniversitesi",
                Schoolsubtitle2="Lojistik",
                CreatedBy = 1,
                CreatedDate = DateTime.Now
            }); ;


        }
    }
}
