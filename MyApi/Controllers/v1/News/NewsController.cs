using AutoMapper;
using Data.Repositories;
using Entities.Newses;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class NewsController : CrudController<NewsDto, News>
    {
        public NewsController(IRepository<News> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
