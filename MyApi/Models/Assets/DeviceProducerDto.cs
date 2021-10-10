using Entities.Assets;
using WebFramework.Api;

namespace MyApi.Models
{

    public class DeviceProducerDto : BaseDto<DeviceProducerDto, DeviceProducer>
    {
        public string Producer { get; set; }
        public bool IsActive { get; set; }
    }
}
