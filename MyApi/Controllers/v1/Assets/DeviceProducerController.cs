using AutoMapper;
using Data.Repositories;
using Entities.Assets;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class DeviceProducerController : CrudController<DeviceProducerDto, DeviceProducer>
    {
        public DeviceProducerController(IRepository<DeviceProducer> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
