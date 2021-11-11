using Entities.Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Entities.Courses
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string CourseTopics { get; set; }
        public string Teacher { get; set; }
        public bool IsActive { get; set; }
        public DateTime HoldingDate { get; set; }
        public ICollection<CourseRequest> CourseRequests { get; set; }
    }
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Title)
                .HasMaxLength(100).IsRequired();
            builder.Property(c => c.Teacher)
                .HasMaxLength(100).IsRequired();
            builder.HasMany(c => c.CourseRequests)
                .WithOne(c => c.Course)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

