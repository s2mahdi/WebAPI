using Entities.SamplingOperations;
using System;
using WebFramework.Api;

namespace MyApi.Models
{

    public class SamplingOperationDto : BaseDto<SamplingOperationDto, SamplingOperation>
    {
        public int SampleCount { get; set; }
        public string SiteAddress { get; set; }
        public string Tell { get; set; }
        public string LetterNum { get; set; }
        public string LetterPath { get; set; }
        public int? InvoiceId { get; set; }
        public string InvoiceDate { get; set; }
        public int? InvoicePrice { get; set; }
        public string InvoicePath { get; set; }
        public string IsActive { get; set; }
        public int SampleTypeId { get; set; }
        public string SampleTypeName { get; set; }
        public int DeviceTypeId { get; set; }
        public string StatusName { get; set; }
        public int StatusId { get; set; }
        public string CreatedAt { get; set; }

    }
}
