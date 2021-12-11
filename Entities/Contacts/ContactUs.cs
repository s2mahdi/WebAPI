using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities
{
    public class ContactUs : BaseEntity
    {
        public string Tell { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Location Location { get; set; }
    }
    public class Location
    {
        public decimal Latitut { get; set; }
        public decimal Intute { get; set; }
    }
    public class ContactUsConfiguration : IEntityTypeConfiguration<ContactUs>
    {
        public void Configure(EntityTypeBuilder<ContactUs> builder)
        {
            builder.Property(c => c.Tell)
                .HasMaxLength(100).IsRequired();
            builder.Property(c => c.Email)
                .HasMaxLength(100).IsRequired();
            builder.OwnsOne<Location>("Location")
                .Property(c=>c.Intute).HasPrecision(18,9);
            builder.OwnsOne<Location>("Location")
                .Property(c => c.Latitut).HasPrecision(18,9);
        }
    }
}

