using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DataInitializer
{
    public class CompanyUserMobileDataInitializer : IdataInitializer
    {
        private readonly IRepository<CompanyUserMobile> _repository;
        public CompanyUserMobileDataInitializer(IRepository<CompanyUserMobile> repository)
        {
            _repository = repository;
        }
        public void InitializeData()
        {
            var companyUserMobile = new CompanyUserMobile
            {
                FirstName = "Jalal",
                LastName = "Mostafania",
                CompanyName = "NiaCopmany",
                CompanyCode = "1234567891",
                Mobile = "09368915297",
                IsActive = false,
                Description = "This is a test data",
                ExpireDateAccess = DateTime.Now
            };
            if (!_repository.TableNoTracking.Any(p => p.Mobile == "09368915297"))
            {
                _repository.Add(companyUserMobile);
            }
        }
    }
}
