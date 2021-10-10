using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Assets
{
    /// <summary>
    /// دستگاه ها
    /// </summary>
    public class DeviceName : BaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class DeviceNameConfiguration : IEntityTypeConfiguration<DeviceName>
    {
        public void Configure(EntityTypeBuilder<DeviceName> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(100).IsRequired();
        }
    }
}




















