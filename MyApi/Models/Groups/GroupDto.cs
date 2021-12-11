using Entities;
using System;
using WebFramework.Api;

namespace MyApi.Models
{
    public class GroupDto : BaseDto<GroupDto, Group>
    {
        public string GroupTitle { get; set; }
    }
}
