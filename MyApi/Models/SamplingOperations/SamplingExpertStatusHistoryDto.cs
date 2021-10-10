using Entities.SamplingOperations;
using WebFramework.Api;

namespace MyApi.Models
{
    public class SamplingExpertStatusHistoryDto : BaseDto<SamplingExpertStatusHistoryDto, SamplingExpertStatusHistory>
    {
        public int StatusId { get; set; }
        public int SamplingExpertId { get; set; }
    }
}
