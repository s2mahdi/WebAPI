using AutoMapper;
using Data.Repositories;
using Entities.Courses;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CourseRequestController : CrudController<CourseRequestDto, CourseRequest>
    {
        public CourseRequestController(IRepository<CourseRequest> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
