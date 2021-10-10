using Entities.Abouts;
using WebFramework.Api;

namespace MyApi.Models
{
    public class AboutUsDto : BaseDto<AboutUsDto, AboutUs>
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
