using Microsoft.Extensions.Caching.Memory;

namespace Teleperformance.Final.Project.Application.Contracts.Cache
{
    public interface IMemoryCacheService : IDisposable
    {

        ICacheEntry CreateEntry(object key);
        void Remove(object key);
        bool TryGetValue(object key, out object value);


    }
}
