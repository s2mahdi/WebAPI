using Common;
using Data.Contracts.Courses;
using Entities.Courses;

namespace Data.Repositories.Courses
{
    public class CourseRequestStatusRepository : Repository<CourseRequestStatus>, ICourseRequestStatusRepository, IScopedDependency
    {
        public CourseRequestStatusRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
