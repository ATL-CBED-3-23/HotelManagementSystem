using HotelAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPI.Persistence.Configurations;

public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
{
    public void Configure(EntityTypeBuilder<RoomType> builder)
    {
        builder.ToTable("RoomTypes", "Hotel");

        builder.HasKey(b => b.Id);
        builder.Property(b => b.Name).IsRequired().HasMaxLength(255);
        builder.Property(b => b.Description).IsRequired().HasMaxLength(300);
        builder.Property(b => b.EntityStatus).HasColumnName("IsDeleted");


        //Relations
        builder.HasMany(b => b.Rooms).WithOne(b => b.RoomType).HasForeignKey(b => b.RoomTypeId);
    }
}