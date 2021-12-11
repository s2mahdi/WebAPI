using Common;
using Data.Contracts.Contacts;
using Entities;

namespace Data.Repositories.ContactUss
{
    public class ContactUsRepository : Repository<ContactUs>, IContactUsRepository, IScopedDependency
    {
        public ContactUsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
