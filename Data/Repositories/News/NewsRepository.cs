using Common;
using Data.Contracts.KNews;
using Entities.Newses;

namespace Data.Repositories.KNews
{
    public class NewsRepository : Repository<News>, INewsRepository, IScopedDependency
    {
        public NewsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
