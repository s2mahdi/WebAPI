using Common;
using Data.Contracts.Assets;
using Entities.Assets;

namespace Data.Repositories.Assets
{
    public class PartRepository : Repository<Part>, IPartRepository, IScopedDependency
    {
        public PartRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
