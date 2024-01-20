using HotelAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPI.Persistence.Configurations
{
    public class CountryConfiguratin : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries", "Hotel");

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(50);
            builder.Property(b => b.EntityStatus).HasColumnName("IsDeleted");

            //Relations
            builder.HasMany(b => b.Cities).WithOne(b => b.Country).HasForeignKey(b => b.CountryId);



        }
    }
}
