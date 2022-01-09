using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Entities.Courses
{
    public class CourseRequest : BaseEntity
    {
        public string CourseTitle { get; set; }
        public int CourseId { get; set; }
        public ICollection<Course> Course { get; set; }
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
        public ICollection<CourseRequestStatus> CourseRequestStatus { get; set; }
        public DateTime StartedDateTime { get; set; }
        public string Description { get; set; }
        public ICollection<Status> Statuses { get; set; }
    }
    public class CourseRequestConfiguration : IEntityTypeConfiguration<CourseRequest>
    {
        public void Configure(EntityTypeBuilder<CourseRequest> builder)
        {
            builder.Property(c => c.InvoicePath)
                .HasMaxLength(100);
            builder.Property(c => c.InvoiceId)
                .HasMaxLength(20);
            builder.Property(c => c.RequestDate)
                .HasMaxLength(50).IsRequired();
        }
    }
}

