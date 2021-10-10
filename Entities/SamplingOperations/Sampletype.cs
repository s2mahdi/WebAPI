using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.SamplingOperations
{
    public class SampleType : BaseEntity
    {
        public string Type { get; set; }
    }
    public class SampleTypeConfiguration : IEntityTypeConfiguration<SampleType>
    {
        public void Configure(EntityTypeBuilder<SampleType> builder)
        {
            builder.Property(c => c.Type)
                .HasMaxLength(100).IsRequired();
        }
    }
}

