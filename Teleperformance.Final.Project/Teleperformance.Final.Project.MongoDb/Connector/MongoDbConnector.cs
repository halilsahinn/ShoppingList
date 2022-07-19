using MongoDB.Driver;
using Teleperformance.Final.Project.Application.Contracts.MongoDb;
using Teleperformance.Final.Project.MongoDb.Configuration;

namespace Teleperformance.Final.Project.MongoDb.Connector
{
    public class MongoDbConnector: IMongoDbService
    {
        #region SUMMARY
        /// <summary>
        /// Burada mongo db ye bağlanan method yazıldı. Bu method: Mongo db ye bağlanır. Konfigürasyondaki Collectionı ile çalışır. 
        /// Diğer method ise farklı bir collection ı seçmek için kullanılır.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        #endregion

        #region METHODS
        public IMongoCollection<T> Connect<T>()
        {
            var client = new MongoClient(MongoDbConfiguration.ConnectionString);
            var db = client.GetDatabase(MongoDbConfiguration.DatabaseName);
            return db.GetCollection<T>(MongoDbConfiguration.Collection);
        }


        public IMongoCollection<T> ConnectTo<T>(string collection)
        {
            var client = new MongoClient(MongoDbConfiguration.ConnectionString);
            var db = client.GetDatabase(MongoDbConfiguration.DatabaseName);
            return db.GetCollection<T>(collection);
        }

        #endregion

 
    }
}
