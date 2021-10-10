using Entities.Assets;
using WebFramework.Api;

namespace MyApi.Models
{

    public class DeviceNameDto : BaseDto<DeviceNameDto, DeviceName>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
