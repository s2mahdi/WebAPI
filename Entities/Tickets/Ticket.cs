using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Entities
{
    public class Ticket : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string FileAttach { get; set; }
        public string AnswerBody { get; set; }
        public DateTime AnswerDate { get; set; }
        public int AnswerUser { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<Status> Status { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public Section Section { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Group Group { get; set; }
    }
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(c => c.Title)
                .HasMaxLength(50).IsRequired();
            builder.HasOne(c => c.Section).WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            builder.Property(c => c.StatusName)
                .HasMaxLength(50);
        }
    }
}

