using AutoMapper;
using Data.Repositories;
using Entities.Assets;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class DeviceModelController : CrudController<DeviceModelDto, DeviceModel>
    {
        public DeviceModelController(IRepository<DeviceModel> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
