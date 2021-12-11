using Common;
using Data.Contracts.Statuses;
using Entities;

namespace Data.Repositories.Statuses
{
    public class StatusRepository : Repository<Status>, IStatusRepository, IScopedDependency
    {
        public StatusRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
