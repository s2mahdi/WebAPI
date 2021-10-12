using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class MobileActivation : BaseEntity
    {
        [Required]
        [StringLength(11)]
        public string Mobile { get; set; }

        [StringLength(5)]
        public string ActivationCode { get; set; }
        public byte Status { get; set; }
        public DateTime StatusDate { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}

public class SmsLoginEventConfiguration : IEntityTypeConfiguration<MobileActivation>
{
    public void Configure(EntityTypeBuilder<MobileActivation> builder)
    {
        builder.Property(c => c.Mobile).HasMaxLength(11);
        builder.Property(c => c.ActivationCode).HasMaxLength(5);
    }
}