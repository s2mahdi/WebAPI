using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Courses
{
    public class CourseRequestStatus : BaseEntity
    {
        public string StatusTitle { get; set; }
    }
    public class CourseRequestStatusConfiguration : IEntityTypeConfiguration<CourseRequestStatus>
    {
        public void Configure(EntityTypeBuilder<CourseRequestStatus> builder)
        {
            builder.Property(c => c.StatusTitle)
                .HasMaxLength(100).IsRequired();
        }
    }
}

