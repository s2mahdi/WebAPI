namespace Entities.Courses
{
    public class CourseRequestStatusHistory : BaseEntity
    {
        public int CourseRequestId { get; set; }
        public CourseRequest CourseRequest { get; set; }
        public int CourseRequestStatusId { get; set; }
        public CourseRequestStatus CourseRequestStatus { get; set; }
    }
}