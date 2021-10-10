using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Statuses
{
    public class Ticket : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string FileAttach { get; set; }
        public string AnswerBody { get; set; }
        public DateTime AnswerDate { get; set; }
        public int AnswerUser { get; set; }
        public int GroupTitle { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(c => c.Title)
                .HasMaxLength(50).IsRequired();
            builder.HasOne(c => c.Section).WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(c => c.Status).WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

