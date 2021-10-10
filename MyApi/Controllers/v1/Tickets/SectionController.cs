using AutoMapper;
using Data.Repositories;
using Entities.Statuses;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class SectionController : CrudController<SectionDto, Section>
    {
        public SectionController(IRepository<Section> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
