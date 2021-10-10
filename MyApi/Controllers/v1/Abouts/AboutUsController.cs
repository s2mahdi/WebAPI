using AutoMapper;
using Data.Repositories;
using Entities.Abouts;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class AboutUsController : CrudController<AboutUsDto, AboutUs>
    {
        public AboutUsController(IRepository<AboutUs> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
