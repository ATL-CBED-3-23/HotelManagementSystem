using HotelAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPI.Persistence.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.ToTable("Rooms", "Hotel");

        builder.HasKey(b => b.Id);
        builder.Property(b => b.Number).IsRequired().HasMaxLength(25);
        builder.Property(b => b.Floor).IsRequired().HasMaxLength(25);
        builder.Property(b => b.Phone).IsRequired().HasMaxLength(400);
        builder.Property(b => b.Price).IsRequired().HasMaxLength(100); 
        builder.Property(b => b.EntityStatus).HasColumnName("IsDeleted");

        //Relations
        builder.HasMany(b => b.Reservations).WithOne(b => b.Room).HasForeignKey(b => b.RoomId);
        builder.HasMany(b => b.Equipments).WithMany(b => b.Rooms);
    }
}