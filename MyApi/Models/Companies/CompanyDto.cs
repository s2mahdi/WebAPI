using Entities.Companies;
using WebFramework.Api;

namespace MyApi.Models
{
    public class CompanyDto : BaseDto<CompanyDto, Company>
    {
        public string FCustomeName { get; set; }
        public string NationalId { get; set; }
        public string EconomicCode { get; set; }
        public string RegistrationCode { get; set; }
        public string TellNumber { get; set; }
        public string FaxNumber { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string PersonId { get; set; }
    }
}
