using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Statuses
{
    public class Section : BaseEntity
    {
        public string SectionName { get; set; }
        public bool IsActive { get; set; }
    }

    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.Property(c => c.SectionName)
                .HasMaxLength(50).IsRequired();
        }
    }
}

