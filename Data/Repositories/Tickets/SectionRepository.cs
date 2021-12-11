using Common;
using Data.Contracts.Tickets;
using Entities;

namespace Data.Repositories.Tickets
{
    public class SectionRepository : Repository<Section>, ISectionRepository, IScopedDependency
    {
        public SectionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
