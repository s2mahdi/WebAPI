using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Models
{
    public class CompanyUserMobileDto : BaseDto<CompanyUserMobileDto, CompanyUserMobile>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public DateTime ExpireDateAccess { get; set; }
        public DateTime DateActiveByUser { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}
