using Common;
using Data.Contracts.Assets;
using Entities.Assets;

namespace Data.Repositories.DeviceNames
{
    public class DeviceNameRepository : Repository<DeviceName>, IdeviceNameRepository, IScopedDependency
    {
        public DeviceNameRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
