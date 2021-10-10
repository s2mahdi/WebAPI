using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Assets
{
    /// <summary>
    ///مدل دستگاه ها
    /// </summary>
    public class DeviceModel : BaseEntity
    {
        public string Model { get; set; }
        public bool IsActive { get; set; }
    }
    public class DeviceModelConfiguration : IEntityTypeConfiguration<DeviceModel>
    {
        public void Configure(EntityTypeBuilder<DeviceModel> builder)
        {
            builder.Property(c => c.Model)
                .HasMaxLength(100).IsRequired();
        }
    }
}




















