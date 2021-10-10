using Entities.Assets;
using WebFramework.Api;

namespace MyApi.Models
{

    public class DeviceModelDto : BaseDto<DeviceModelDto, DeviceModel>
    {
        public string Model { get; set; }
        public bool IsActive { get; set; }
    }
}
