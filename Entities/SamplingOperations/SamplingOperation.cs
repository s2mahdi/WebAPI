using Entities.Statuses;
using Entities.Statuses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.SamplingOperations
{
    public class SamplingOperation : BaseEntity
    {
        public int SampleCount { get; set; }
        public string SiteAddress { get; set; }
        public string Tell { get; set; }
        public string LetterNum { get; set; }
        public string LetterPath { get; set; }
        public int InvoiceId { get; set; }
        public string InvoiceDate { get; set; }
        public int InvoicePrice { get; set; }
        public string InvoicePath { get; set; }
        public string IsActive { get; set; }
        public int SampleTypeId { get; set; }
        public SampleType SampleType { get; set; }
        public int DeviceTypeId { get; set; }
        public DeviceType DeviceType { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }

    public class SamplingOperationConfiguration : IEntityTypeConfiguration<SamplingOperation>
    {
        public void Configure(EntityTypeBuilder<SamplingOperation> builder)
        {
            builder.Property(c => c.SiteAddress)
                .HasMaxLength(100).IsRequired();
            builder.Property(c => c.Tell)
                .HasMaxLength(50).IsRequired();
            builder.Property(c => c.LetterNum)
                .HasMaxLength(50).IsRequired();
            builder.Property(c => c.LetterPath)
                .HasMaxLength(100).IsRequired();
            builder.Property(c => c.InvoiceId)
                .HasMaxLength(20).IsRequired();
            builder.Property(c => c.InvoicePath)
                .HasMaxLength(100).IsRequired();
        }
    }

}

