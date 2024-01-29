using HotelAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPI.Persistence.Configurations
{
    public class AboutAppConfiguration : IEntityTypeConfiguration<AboutApp>
    {
        public void Configure(EntityTypeBuilder<AboutApp> builder)
        {
            builder.ToTable("AboutApps", "Hotel");

            builder.HasKey(b => b.Id);
            builder.Property(b => b.AppName).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Site).HasMaxLength(50);
            builder.Property(b => b.AppVersion).HasMaxLength(50);
            builder.Property(b => b.EntityStatus).HasColumnName("IsDeleted");
        }
    }
}
