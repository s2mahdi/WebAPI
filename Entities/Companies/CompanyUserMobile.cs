using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities
{
    public class CompanyUserMobile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public DateTime ExpireDateAccess { get; set; }
        public DateTime DateActiveByUser { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}

public class CompanyConfiguration : IEntityTypeConfiguration<CompanyUserMobile>
{
    public void Configure(EntityTypeBuilder<CompanyUserMobile> builder)
    {
        builder.HasIndex(c => c.Mobile).IsUnique(true);
        builder.Property(p => p.Mobile).IsRequired().HasMaxLength(11);
        builder.Property(p => p.FirstName).HasMaxLength(20);
        builder.Property(p => p.LastName).HasMaxLength(50);
        builder.Property(p => p.CompanyName).HasMaxLength(50);
        builder.Property(p => p.CompanyCode).HasMaxLength(10);
    }
}