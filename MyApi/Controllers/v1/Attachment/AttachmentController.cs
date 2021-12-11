using AutoMapper;
using Common.Exceptions;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    [ApiVersion("1")]
    public class AttachmentController : CrudController<AttachmentDto, Attachment>
    {
        public AttachmentController(IRepository<Attachment> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        [HttpPost]
        [Route("UploadFile")]
        public async Task UploadFile(CancellationToken cancellationToken)
        {
            var file = await GetFromFile(cancellationToken);
            try
            {
                var newAttachent = new Attachment
                {
                    AttachmentFile = file[0].AttachmentFile,
                    AttachmentTitle = file[0].AttachmentTitle,
                    AttchmentType = file[0].AttchmentType,

    };
                await Repository.AddAsync(newAttachent, cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        protected async Task<List<AttachmentDto>> GetFromFile(CancellationToken cancellationToken)
        {
            var files = new List<AttachmentDto>();
            var request = HttpContext.Request;

            if (request.HasFormContentType)
            {
                foreach (var fromFile in request.Form.Files)
                {
                    var dto = new AttachmentDto() { AttachmentTitle = fromFile.FileName, AttchmentType = fromFile.ContentType };
                    using (var ms = new MemoryStream((int)fromFile.Length))
                    {
                        await fromFile.CopyToAsync(ms, cancellationToken);
                        dto.AttachmentFile = ms.ToArray();
                    }

                    files.Add(dto);
                }
            }
            return files;
        }
    }
}
