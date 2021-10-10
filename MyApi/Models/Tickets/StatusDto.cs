using Entities.Statuses;
using WebFramework.Api;

namespace MyApi.Models
{
    public class SectionDto : BaseDto<SectionDto, Section>
    {
        public string SectionName { get; set; }
        public bool IsActive { get; set; }
    }
}
