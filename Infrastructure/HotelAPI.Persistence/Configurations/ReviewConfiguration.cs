using HotelAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPI.Persistence.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("Reviews", "Hotel");

        builder.HasKey(b => b.Id);
        builder.Property(b => b.Content).IsRequired().HasMaxLength(255);
        builder.Property(b => b.EntityStatus).HasColumnName("IsDeleted");

        //Relations
        builder.HasOne(b => b.HotelUser).WithMany(b => b.Reviews).HasForeignKey(b => b.HotelUserId);


    }
}
