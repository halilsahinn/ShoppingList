namespace Teleperformance.Final.Project.Application.Contracts.Cache
{
    public interface IRedisDistrubutedCacheService
    {

        Task<T> GetObjectAsync<T>(string key);
        Task SetObjectAsync<T>(string key, T value, int absoluteExpirationMinute = 1,
            int slidingExpirationSecond = 15);


    }
}
