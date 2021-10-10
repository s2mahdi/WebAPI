using AutoMapper;
using Data.Repositories;
using Entities.SamplingOperations;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class SamplingExpertStatusHistoryController : CrudController<SamplingExpertStatusHistoryDto, SamplingExpertStatusHistory>
    {
        public SamplingExpertStatusHistoryController(IRepository<SamplingExpertStatusHistory> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
