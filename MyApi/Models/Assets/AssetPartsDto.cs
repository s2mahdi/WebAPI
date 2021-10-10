using Entities.Assets;
using WebFramework.Api;

namespace MyApi.Models
{

    public class AssetPartsDto : BaseDto<AssetPartsDto, AssetPart>
    {
        public int PartId { get; set; }
        public int AssetPartsId { get; set; }
        public int PartNewName { get; set; }
        public int PartDesc { get; set; }
        public int Volume { get; set; }
        public int VolumeKind { get; set; }
        public int OilChange { get; set; }
        public int OilChangeType { get; set; }
        public int OilSampling { get; set; }
        public int OilSamplingType { get; set; }
        public int DescPart { get; set; }
        public int OilChangeDate { get; set; }
        public int OilPhysicalFilteringDate { get; set; }
        public int OilChemicalFilteringDate { get; set; }
        public int OverhaulDate { get; set; }
        public int IsActive { get; set; }
        public int DescOilChange { get; set; }
    }
}
