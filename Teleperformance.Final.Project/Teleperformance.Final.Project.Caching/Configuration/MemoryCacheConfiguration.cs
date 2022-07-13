using Microsoft.Extensions.Caching.Memory;

namespace Teleperformance.Final.Project.Caching.Configuration
{
    public abstract class MemoryCacheConfiguration : MemoryCacheEntryOptions
    {

        public MemoryCacheConfiguration()
        {
            AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(1);
            Priority = CacheItemPriority.High;
        }




    }
}
