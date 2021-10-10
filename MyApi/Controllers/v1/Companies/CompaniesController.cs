using AutoMapper;
using Data.Repositories;
using Entities.Companies;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CompaniesController : CrudController<CompanyDto, Company>
    {
        public CompaniesController(IRepository<Company> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
