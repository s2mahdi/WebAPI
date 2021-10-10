using AutoMapper;
using Data.Repositories;
using Entities.Assets;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class DeviceNameController : CrudController<DeviceNameDto, DeviceName>
    {
        public DeviceNameController(IRepository<DeviceName> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
