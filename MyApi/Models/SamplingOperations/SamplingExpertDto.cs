using Entities.SamplingOperations;
using WebFramework.Api;

namespace MyApi.Models
{

    public class SamplingExpertDto : BaseDto<SamplingExpertDto, SamplingExpert>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
