using Common;
using Data.Contracts.Courses;
using Entities.Courses;

namespace Data.Repositories.Courses
{
    public class CourseRepository : Repository<Course>, ICourseRepository, IScopedDependency
    {
        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
