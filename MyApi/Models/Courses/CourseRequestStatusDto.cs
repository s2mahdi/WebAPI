using Entities.Courses;
using WebFramework.Api;

namespace MyApi.Models
{
    public class CourseRequestStatusDto : BaseDto<CourseRequestStatusDto, CourseRequestStatus>
    {
        public string StatusTitle { get; set; }

    }
}
