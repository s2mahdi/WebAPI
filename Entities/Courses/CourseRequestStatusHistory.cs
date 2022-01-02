using System.Collections.Generic;

namespace Entities.Courses
{
    public class CourseRequestStatusHistory : BaseEntity
    {
        public int CourseRequestId { get; set; }
        public ICollection<CourseRequest> CourseRequest { get; set; }
        public int CourseRequestStatusId { get; set; }
        public ICollection<CourseRequestStatus> CourseRequestStatus { get; set; }
    }
}