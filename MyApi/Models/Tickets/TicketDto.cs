using Entities;

using System;
using WebFramework.Api;

namespace MyApi.Models
{
    public class TicketDto : BaseDto<TicketDto, Ticket>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string FileAttach { get; set; }
        public string AnswerBody { get; set; }
        public int AnswerUser { get; set; }
        public DateTime AnswerDate { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
