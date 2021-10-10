using AutoMapper;
using Data.Repositories;
using Entities.Courses;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CourseRequestStatusHistoryController : CrudController<CourseRequestStatusHistoryDto, CourseRequestStatusHistory>
    {
        public CourseRequestStatusHistoryController(IRepository<CourseRequestStatusHistory> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
