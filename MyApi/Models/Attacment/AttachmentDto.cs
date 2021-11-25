using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Models
{
    public class AttachmentDto :BaseDto<AttachmentDto,Attachment>
    {
        public string AttachmentTitle { get; set; }
        public string AttchmentType { get; set; }
        public DateTime UploadDateTime { get; set; }
        public byte[] AttachmentFile { get; set; }
    }
}
