using Common;
using Data.Contracts.Statuses;
using Entities.Statuses;

namespace Data.Repositories.Statuses
{
    public class StatusRepository : Repository<Status>, IStatusRepository, IScopedDependency
    {
        public StatusRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
