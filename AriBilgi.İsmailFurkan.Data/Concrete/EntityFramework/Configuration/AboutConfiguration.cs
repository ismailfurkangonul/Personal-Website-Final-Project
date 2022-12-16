using AriBilgi.IsmailFurkan.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Configuration
{
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Name).HasMaxLength(70);

            builder.Property(a => a.Explain).HasMaxLength(500);
            builder.Property(a => a.Job).HasMaxLength(500);
            builder.Property(a => a.Social).HasMaxLength(500);

            builder.HasData(new About
            {
                Id = 1,
                Name = "İsmail Furkan Gönül",
                Explain = "Yazılım",
                CreatedBy = 1,
                CreatedDate = DateTime.Now
            });






        }
    }
}
