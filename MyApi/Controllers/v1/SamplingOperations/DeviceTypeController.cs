using AutoMapper;
using Data.Repositories;
using Entities.SamplingOperations;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class DeviceTypeController : CrudController<DeviceTypeDto, DeviceType>
    {
        public DeviceTypeController(IRepository<DeviceType> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
