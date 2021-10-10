using Common;
using Data.Contracts.SamplingOperations;
using Entities.SamplingOperations;

namespace Data.Repositories.SamplingOperations
{
    public class SamplingOperationRepository : Repository<SamplingOperation>, ISamplingOperationRepository, IScopedDependency
    {
        public SamplingOperationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
