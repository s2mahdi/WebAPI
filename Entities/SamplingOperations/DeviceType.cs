using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.SamplingOperations
{
    public class DeviceType : BaseEntity
    {
        public string Type { get; set; }
    }
    public class DeviceTypeConfiguration : IEntityTypeConfiguration<DeviceType>
    {
        public void Configure(EntityTypeBuilder<DeviceType> builder)
        {
            builder.Property(c => c.Type)
                .HasMaxLength(100).IsRequired();
        }
    }
}

