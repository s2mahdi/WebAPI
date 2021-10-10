using Entities.SamplingOperations;
using WebFramework.Api;

namespace MyApi.Models
{

    public class SampleTypeDto : BaseDto<SampleTypeDto, SampleType>
    {
        public string Type { get; set; }

    }
}
