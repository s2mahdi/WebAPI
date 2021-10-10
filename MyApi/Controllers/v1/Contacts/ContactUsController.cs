using AutoMapper;
using Data.Repositories;
using Entities.Contacts;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class ContactUsController : CrudController<ContactUsDto, ContactUs>
    {
        public ContactUsController(IRepository<ContactUs> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
