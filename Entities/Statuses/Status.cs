using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class Status : BaseEntity
    {
        public int ParentID { get; set; }
        public string StatusName { get; set; }
        public bool IsActive { get; set; }
        public string StatusColorCode { get; set; }
    }
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.Property(c => c.StatusName)
                .HasMaxLength(50).IsRequired();
        }
    }
}

