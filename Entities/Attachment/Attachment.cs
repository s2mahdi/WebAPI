using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Attachment : BaseEntity<int>
    {
        public string AttachmentTitle { get; set; }
        public string AttchmentType { get; set; }
        public DateTime UploadDateTime { get; set; }
        public byte[] AttachmentFile { get; set; }
    }

    public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.Property(p => p.AttachmentTitle).HasMaxLength(100);
            builder.Property(p => p.AttchmentType).HasMaxLength(5);
        }
    }
}

