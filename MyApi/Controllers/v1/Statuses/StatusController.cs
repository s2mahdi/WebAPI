using AutoMapper;
using Data.Repositories;
using Entities.Statuses;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class StatusController : CrudController<StatusDto, Status>
    {
        public StatusController(IRepository<Status> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
