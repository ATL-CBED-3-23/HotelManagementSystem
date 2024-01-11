using HotelAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPI.Persistence.Configurations;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("Reservations", "Hotel");

        builder.HasKey(b => b.Id);
        builder.Property(b => b.CheckInDate).IsRequired();
        builder.Property(b => b.EntityStatus).HasColumnName("IsDeleted");

       
    }
}