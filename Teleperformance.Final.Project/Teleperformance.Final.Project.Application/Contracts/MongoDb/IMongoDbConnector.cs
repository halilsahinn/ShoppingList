using MongoDB.Driver;

namespace Teleperformance.Final.Project.Application.Contracts.MongoDb
{
    public interface IMongoDbConnector
    {
        public IMongoCollection<T> Connect<T>();
        public IMongoCollection<T> ConnectTo<T>(string collection);

    }
}
