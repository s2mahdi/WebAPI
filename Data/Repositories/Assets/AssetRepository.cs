using Common;
using Data.Contracts.Assets;
using Entities.Assets;

namespace Data.Repositories.Assets
{
    public class AssetRepository : Repository<Asset>, IAssetRepository, IScopedDependency
    {
        public AssetRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
