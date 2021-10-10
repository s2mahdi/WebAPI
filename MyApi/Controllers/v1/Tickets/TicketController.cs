using AutoMapper;
using Data.Repositories;
using Entities.Statuses;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class TicketController : CrudController<TicketDto, Ticket>
    {
        public TicketController(IRepository<Ticket> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
