using Common;
using Data.Contracts.Contacts;
using Entities.Contacts;

namespace Data.Repositories.ContactUss
{
    public class ContactUsRepository : Repository<ContactUs>, IContactUsRepository, IScopedDependency
    {
        public ContactUsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
