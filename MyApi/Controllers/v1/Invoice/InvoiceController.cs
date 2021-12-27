using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using Entities;
using WebFramework.Api;
using Data.Repositories;
using AutoMapper;

namespace MyApi.Controllers.v1
{
    public class InvoiceController : CrudController<InvoiceDto,Invoice>
    {
        public InvoiceController(IRepository<Invoice> repository, IMapper mapper)
           : base(repository, mapper)
        {
        }
    }
}
