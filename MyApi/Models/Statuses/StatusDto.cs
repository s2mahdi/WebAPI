using Entities;
using System;
using WebFramework.Api;

namespace MyApi.Models
{
    public class StatusDto : BaseDto<StatusDto, Status>
    {
        public int ParentID { get; set; }
        public string StatusName { get; set; }
        public bool IsActive { get; set; }
        public string StatusColorCode { get; set; }
    }
}
