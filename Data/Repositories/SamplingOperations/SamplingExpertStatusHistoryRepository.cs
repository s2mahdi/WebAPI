using Common;
using Data.Contracts.SamplingOperations;
using Entities.SamplingOperations;

namespace Data.Repositories.SamplingOperations
{
    public class SamplingExpertStatusHistoryRepository : Repository<SamplingExpertStatusHistory>, ISamplingExpertStatusHistoryRepository, IScopedDependency
    {
        public SamplingExpertStatusHistoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
