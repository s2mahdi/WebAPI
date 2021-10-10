using Entities.Statuses;
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
        public int GroupTitle { get; set; }
        public int StatusId { get; set; }
    }
}
