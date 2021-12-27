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
        public string InvoiceDate { get; set; }
        public decimal InvoicePrice { get; set; }
        public int RequestLetterNo { get; set; }
        public string RequestLetterDate { get; set; }
        public int StatusName { get; set; }
        public decimal VAT { get; set; }
        public int AttachmentId { get; set; }
        public int StatusId { get; set; }

    }
}
