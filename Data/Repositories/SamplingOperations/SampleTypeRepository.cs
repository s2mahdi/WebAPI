using Common;
using Data.Contracts.SamplingOperations;
using Entities.SamplingOperations;

namespace Data.Repositories.SamplingOperations
{
    public class SampleTypeRepository : Repository<SampleType>, ISampleTypeRepository, IScopedDependency
    {
        public SampleTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
