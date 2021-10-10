using AutoMapper;
using Data.Repositories;
using Entities.SamplingOperations;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class SamplingOperationController : CrudController<SamplingOperationDto, SamplingOperation>
    {
        public SamplingOperationController(IRepository<SamplingOperation> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
