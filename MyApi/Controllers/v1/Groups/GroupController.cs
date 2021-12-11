using AutoMapper;
using Data.Repositories;
using Entities;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class GroupController : CrudController<GroupDto, Group>
    {
        public GroupController(IRepository<Group> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
