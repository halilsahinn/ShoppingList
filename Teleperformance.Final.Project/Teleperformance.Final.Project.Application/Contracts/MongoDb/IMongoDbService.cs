using MongoDB.Driver;

namespace Teleperformance.Final.Project.Application.Contracts.MongoDb
{
    public interface IMongoDbService
    {
        public IMongoCollection<T> Connect<T>();
        public IMongoCollection<T> ConnectTo<T>(string collection);

    }
}
