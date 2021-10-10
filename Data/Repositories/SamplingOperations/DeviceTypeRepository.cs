using Common;
using Data.Contracts.SamplingOperations;
using Entities.SamplingOperations;

namespace Data.Repositories.SamplingOperations
{
    public class DeviceTypeRepository : Repository<DeviceType>, IdeviceTypeRepository, IScopedDependency
    {
        public DeviceTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
