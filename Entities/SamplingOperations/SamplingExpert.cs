using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Entities.SamplingOperations
{
    public class SamplingExpert : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StatusName { get; set; }
        public int StatusId { get; set; }
        public ICollection<Status> Status { get; set; }
    }
    public class SamplingExpertConfiguration : IEntityTypeConfiguration<SamplingExpert>
    {
        public void Configure(EntityTypeBuilder<SamplingExpert> builder)
        {
            builder.Property(c => c.LastName)
                .HasMaxLength(100).IsRequired();

            builder.Property(c => c.FirstName)
                .HasMaxLength(100).IsRequired();
        }
    }
}

