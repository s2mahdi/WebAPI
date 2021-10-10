using Common;

namespace Services.DataInitializer
{
    public interface IdataInitializer : IScopedDependency
    {
        void InitializeData();
    }
}
