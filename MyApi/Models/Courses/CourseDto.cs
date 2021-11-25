using Entities.Courses;
using System;
using WebFramework.Api;

namespace MyApi.Models
{
    
    public class CourseDto : BaseDto<CourseDto, Course>
    {
        public string Title { get; set; }
        public string CourseTopics { get; set; }
        public string Teacher { get; set; }
        public bool IsActive { get; set; }
        public DateTime HoldingDate { get; set; }
    }
}
