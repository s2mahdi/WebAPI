using Entities.Assets;
using WebFramework.Api;

namespace MyApi.Models
{

    public class AssetDto : BaseDto<AssetDto, Asset>
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
    }
}
