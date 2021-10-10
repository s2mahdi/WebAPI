using AutoMapper;
using Data.Repositories;
using Entities.Courses;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CourseRequestStatusController : CrudController<CourseRequestStatusDto, CourseRequestStatus>
    {
        public CourseRequestStatusController(IRepository<CourseRequestStatus> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
