using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class MobileActivation : BaseEntity
    {
        public string Mobile { get; set; }
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
        builder.HasIndex(c => c.Mobile).IsUnique(true);
        builder.Property(c => c.Mobile).IsRequired().HasMaxLength(11);
        builder.Property(c => c.ActivationCode).HasMaxLength(5);
       
    }
}