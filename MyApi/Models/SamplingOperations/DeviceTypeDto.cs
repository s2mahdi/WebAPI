using Entities.SamplingOperations;
using WebFramework.Api;

namespace MyApi.Models
{

    public class DeviceTypeDto : BaseDto<DeviceTypeDto, DeviceType>
    {
        public string Type { get; set; }

    }
}
