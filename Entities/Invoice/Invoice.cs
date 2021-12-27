using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class Invoice : BaseEntity<int>
    {
        public int InvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public decimal InvoicePrice { get; set; }
        public int  RequestLetterNo { get; set; }
        public string  RequestLetterDate { get; set; }
        public int StatusName { get; set; }
        public decimal VAT { get; set; }
        public int AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.Property(c => c.InvoiceDate)
                .HasMaxLength(50);
            builder.Property(c => c.RequestLetterDate)
                .HasMaxLength(50);
            builder.Property(c => c.StatusName)
                .HasMaxLength(50);
        }
    }
}

