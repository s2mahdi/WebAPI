using AutoMapper;
using Data.Repositories;
using Entities.Courses;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CourseController : CrudController<CourseDto, Course>
    {
        public CourseController(IRepository<Course> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
