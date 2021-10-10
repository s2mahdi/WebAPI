using AutoMapper;
using Data.Repositories;
using Entities.SamplingOperations;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class SampleTypeController : CrudController<SampleTypeDto, SampleType>
    {
        public SampleTypeController(IRepository<SampleType> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
