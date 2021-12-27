using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Models
{
    public class InvoiceDto : BaseDto<InvoiceDto, Invoice>
    {
        public int InvoiceNo { get; set; }
        public string invoiceDate { get; set; }
        public int invoicePrice { get; set; }
        public int AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
    }
}
