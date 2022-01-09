using Entities.Courses;
using System;
using WebFramework.Api;

namespace MyApi.Models
{
    public class CourseRequestDto : BaseDto<CourseRequestDto, CourseRequest>
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string RequestDate { get; set; }
        public int AvalabelPerson { get; set; }
        public string LocationDesc { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceDate { get; set; }
        public int InvoicePrice { get; set; }
        public string InvoicePath { get; set; }
        public int CourseRequestStatusId { get; set; }
        public DateTime StartedDateTime { get; set; }
        public string Description { get; set; }
        public string StatusName { get; set; }
    }
}
