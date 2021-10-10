using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections;
using System.Collections.Generic;

namespace Entities.Assets
{
    /// <summary>
    /// تجهیزات
    /// </summary>
    public class Asset : BaseEntity, IAuditable
    {
        public int DeviceKind { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceProducer { get; set; }
        public int ProduceYear { get; set; }
        public float AvgWorkPerDay { get; set; }
        public int WorkPerDayKind { get; set; }
        public int WorkPerWeek { get; set; }


        #region فیلدهای صنعتی		
        public string OilVolume { get; set; }
        public string OilVolumeKind { get; set; }
        public string Criticaly { get; set; }
        #endregion

        #region ترانس
        public string TransSN { get; set; }
        public string TransKind { get; set; }
        public string TransOil { get; set; }
        public string TransOilKind { get; set; }
        public string TransPower { get; set; }
        public bool TransOilSharing { get; set; }
        public string TapchangerOil { get; set; }
        public string TapchangerOilKind { get; set; }
        public string VoltageFirst { get; set; }
        public string VoltageFirstKind { get; set; }
        public string VoltageSecend { get; set; }
        public string VoltageSecendKind { get; set; }
        public string TransLoad { get; set; }
        public string TransLoadKind { get; set; }
        public bool IsActive { get; set; }
        #endregion

        public ICollection<AssetPart> AssetParts { get; set; }
    }

    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.Property(p => p.DeviceCode)
                .IsRequired().HasMaxLength(50);
            builder.Property(p => p.DeviceName)
                .IsRequired().HasMaxLength(100);
            builder.Property(p => p.DeviceModel)
                .IsRequired().HasMaxLength(100);
            builder.Property(p => p.DeviceProducer)
                .IsRequired().HasMaxLength(100);
            builder.Property(p => p.DeviceCode)
                .IsRequired().HasMaxLength(50);

            builder.HasMany(c => c.AssetParts)
                .WithOne(c => c.Asset)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}




















