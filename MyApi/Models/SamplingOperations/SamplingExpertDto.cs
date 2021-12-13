using Entities.SamplingOperations;
using System;
using WebFramework.Api;

namespace MyApi.Models
{

    public class SamplingExpertDto : BaseDto<SamplingExpertDto, SamplingExpert>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StatusName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int StatusId { get; set; }
    }
}
