using Common;
using Data.Contracts.Assets;
using Entities.Assets;

namespace Data.Repositories.Assets
{
    public class DeviceModelRepository : Repository<DeviceModel>, IdeviceModelRepository, IScopedDependency
    {
        public DeviceModelRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
