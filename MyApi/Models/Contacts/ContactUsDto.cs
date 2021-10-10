using Entities.Contacts;
using WebFramework.Api;

namespace MyApi.Models
{
    public class ContactUsDto : BaseDto<ContactUsDto, ContactUs>
    {
        public string Tell { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Location Location { get; set; }
    }
}
