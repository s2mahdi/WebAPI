using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice : BaseEntity<int>
    {
        public int InvoiceNo { get; set; }
        public string invoiceDate { get; set; }
        public int invoicePrice { get; set; }
        public int AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
    }
}

