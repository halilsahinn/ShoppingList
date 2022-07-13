using Microsoft.Extensions.Caching.Memory;
using Teleperformance.Final.Project.Application.Contracts.Cache;
using Teleperformance.Final.Project.Caching.Configuration;

namespace Teleperformance.Final.Project.Caching
{
    public class MemoryCacheManager : MemoryCacheConfiguration, IMemoryCacheService
    {
        #region FIELDS
        private readonly IMemoryCache _memoryCache;
        #endregion

        #region CTOR
        public MemoryCacheManager(IMemoryCache memoryCache) => _memoryCache = memoryCache;
        #endregion

        #region METHODS
        public ICacheEntry CreateEntry(object key)
        {
            return _memoryCache.CreateEntry(key);
        }

        public void Dispose()
        {
            _memoryCache.Dispose();
        }

        public void Remove(object key)
        {
            _memoryCache.Remove(key);
        }

        public bool TryGetValue(object key, out object value)
        {
            return _memoryCache.TryGetValue(key, out value);
        }
        #endregion

    }
}
