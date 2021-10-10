using Common;
using Data.Contracts.SamplingOperations;
using Entities.SamplingOperations;

namespace Data.Repositories.SamplingOperations
{
    public class SamplingExpertRepository : Repository<SamplingExpert>, ISamplingExpertRepository, IScopedDependency
    {
        public SamplingExpertRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
