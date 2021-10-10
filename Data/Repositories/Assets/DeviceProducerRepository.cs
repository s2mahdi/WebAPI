using Common;
using Data.Contracts.Assets;
using Entities.Assets;

namespace Data.Repositories.Assets
{
    public class DeviceProducerRepository : Repository<DeviceProducer>, IdeviceProducerRepository, IScopedDependency
    {
        public DeviceProducerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
