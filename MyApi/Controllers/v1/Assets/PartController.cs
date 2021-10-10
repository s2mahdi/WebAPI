using AutoMapper;
using Data.Repositories;
using Entities.Assets;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class PartController : CrudController<PartDto, Part>
    {
        public PartController(IRepository<Part> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
