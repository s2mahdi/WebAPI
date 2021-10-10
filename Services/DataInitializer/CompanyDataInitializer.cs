using Data.Repositories;
using Entities.Companies;
using System.Linq;

namespace Services.DataInitializer
{
    public class CompanyDataInitializer : IdataInitializer
    {
        private readonly IRepository<Company> repository;

        public CompanyDataInitializer(IRepository<Company> repository)
        {
            this.repository = repository;
        }

        public void InitializeData()
        {
            if (!repository.TableNoTracking.Any(p => p.FCustomeName == "شرکت اولیه"))
            {
                repository.Add(new Company
                {
                    FCustomeName = "شرکت اولیه",
                    Address= "Address",
                    EconomicCode= "EconomicCode",
                    FaxNumber= "FaxNumber",
                    NationalId= "NationalId",
                    PersonId= "PersonId",
                    RegistrationCode= "RegistrationCode",
                    TellNumber= "TellNumber",
                    ZipCode="ZipCode"
                });
            }
        }
    }
}
