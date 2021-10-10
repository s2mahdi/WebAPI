using Common;
using Data.Contracts.Assets;
using Entities.Assets;

namespace Data.Repositories.Assets
{
    public class AssetPartsRepository : Repository<AssetPart>, IAssetPartsRepository, IScopedDependency
    {
        public AssetPartsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
