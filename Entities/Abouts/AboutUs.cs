using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Abouts
{
    public class AboutUs : BaseEntity
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
    public class AboutUsConfiguration : IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
        {
            builder.Property(c => c.Title)
                .HasMaxLength(100).IsRequired();
            builder.Property(c => c.ImagePath)
                .HasMaxLength(100).IsRequired();
        }
    }
}