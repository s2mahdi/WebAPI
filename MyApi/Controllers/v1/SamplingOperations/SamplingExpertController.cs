using AutoMapper;
using Data.Repositories;
using Entities.SamplingOperations;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class SamplingExpertController : CrudController<SamplingExpertDto, SamplingExpert>
    {
        public SamplingExpertController(IRepository<SamplingExpert> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
