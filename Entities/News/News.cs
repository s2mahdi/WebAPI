using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Newses
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.Property(c => c.Title)
                .HasMaxLength(100).IsRequired();
            builder.Property(c => c.ImagePath)
                .HasMaxLength(100).IsRequired();
        }
    }
}