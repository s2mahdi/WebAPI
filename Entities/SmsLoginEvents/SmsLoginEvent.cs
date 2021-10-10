using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities
{
    public class SmsLoginEvent : BaseEntity
    {
        public string MobileNumber { get; set; }
        public int Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsValidate { get; set; }
        public bool IsActive { get; set; }

    }

    public class SmsLoginEventConfiguration : IEntityTypeConfiguration<SmsLoginEvent>
    {
        public void Configure(EntityTypeBuilder<SmsLoginEvent> builder)
        {
            builder.Property(c => c.Code).IsRequired().HasMaxLength(5);
            builder.Property(c => c.MobileNumber).IsRequired().HasMaxLength(12);
            builder.Property(c => c.CreatedDate).IsRequired();
        }
    }
}
