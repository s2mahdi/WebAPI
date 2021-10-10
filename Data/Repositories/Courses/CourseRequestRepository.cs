using Common;
using Data.Contracts.Courses;
using Entities.Courses;

namespace Data.Repositories.Courses
{
    public class CourseRequestRepository : Repository<CourseRequest>, ICourseRequestRepository, IScopedDependency
    {
        public CourseRequestRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
