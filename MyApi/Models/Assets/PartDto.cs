using Entities.Assets;
using WebFramework.Api;

namespace MyApi.Models
{

    public class PartDto : BaseDto<PartDto, Part>
    {
        public string PartName { get; set; }
        public int PartKind { get; set; }
        public bool IsActive { get; set; }
    }
}
