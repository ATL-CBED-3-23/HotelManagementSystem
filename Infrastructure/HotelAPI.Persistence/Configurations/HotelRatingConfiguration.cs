using HotelAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Persistence.Configurations
{
    public class HotelRatingConfiguration : IEntityTypeConfiguration<HotelRating>
    {
        public void Configure(EntityTypeBuilder<HotelRating> builder)
        {
            builder.ToTable("HotelRatings", "Hotel");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Rating).IsRequired();
            //relation
            builder.HasOne(b => b.Hotel).WithMany(b => b.Ratings).HasForeignKey(b => b.HotelId);
           // builder.HasOne(b => b.User).WithOne(b => b.HotelRating).HasForeignKey<HotelRating>(b => b.UserId);
        }
    }
}
