using AutoMapper;
using Data.Repositories;
using Entities;
using MyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CompanyUserMobileController : CrudController<CompanyUserMobileDto, CompanyUserMobile>
    {
        public CompanyUserMobileController(IRepository<CompanyUserMobile> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
