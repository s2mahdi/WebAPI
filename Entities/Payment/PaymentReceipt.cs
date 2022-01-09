using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PaymentReceipt : BaseEntity<int>
    {
        public decimal Price { get; set; }
        public string PaymentDate { get; set; }
        public string BankName { get; set; }
        public int PaymentReceiptNo { get; set; }
        public string PaymentReceiptStatus { get; set; }
        public ICollection<Status> Status { get; set; }
        public ICollection<Attachment> Attachment { get; set; }
    }
    public class PaymentReceiptConfiguration : IEntityTypeConfiguration<PaymentReceipt>
    {
        public void Configure(EntityTypeBuilder<PaymentReceipt> builder)
        {
            builder.Property(p => p.PaymentReceiptStatus)
                   .HasMaxLength(50);
            builder.Property(p => p.BankName)
                   .HasMaxLength(200);
        }
    }
}
