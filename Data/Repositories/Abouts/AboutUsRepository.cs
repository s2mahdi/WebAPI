using Common;
using Data.Contracts.Abouts;
using Entities.Abouts;

namespace Data.Repositories.Abouts
{
    public class AboutUsRepository : Repository<AboutUs>, IAboutUsRepository, IScopedDependency
    {
        public AboutUsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
