using HotelAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPI.Persistence.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("Cities","Hotel");
        
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Name).IsRequired().HasMaxLength(50);
        builder.Property(b => b.PostalCode).HasMaxLength(50);
        builder.Property(b => b.EntityStatus).HasColumnName("IsDeleted");

        //Relations
        builder.HasMany(b => b.Hotels).WithOne(b => b.City).HasForeignKey(b => b.CityId);
        builder.HasOne(b => b.Country).WithMany(b => b.Cities).HasForeignKey(b => b.CountryId);


    }
}
