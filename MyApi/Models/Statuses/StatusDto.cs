using Entities.Statuses;
using System;
using WebFramework.Api;

namespace MyApi.Models
{
    public class StatusDto : BaseDto<StatusDto, Status>
    {
        public string StatusName { get; set; }
        public bool IsActive { get; set; }
    }
}
