using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Assets
{
    /// <summary>
    ///سازنده دستگاه ها
    /// </summary>
    public class DeviceProducer : BaseEntity
    {
        public string Producer { get; set; }
        public bool IsActive { get; set; }
    }
    public class DeviceProducerConfiguration : IEntityTypeConfiguration<DeviceProducer>
    {
        public void Configure(EntityTypeBuilder<DeviceProducer> builder)
        {
            builder.Property(c => c.Producer)
                .HasMaxLength(100).IsRequired();
        }
    }
}




















