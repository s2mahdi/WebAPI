using Entities.Courses;
using WebFramework.Api;

namespace MyApi.Models
{

    public class CourseRequestStatusHistoryDto : BaseDto<CourseRequestStatusHistoryDto, CourseRequestStatusHistory>
    {
        public int CourseRequestId { get; set; }
        public int CourseRequestStatusId { get; set; }
    }
}
