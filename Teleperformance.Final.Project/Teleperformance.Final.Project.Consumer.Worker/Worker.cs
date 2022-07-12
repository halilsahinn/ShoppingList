using System.Diagnostics;
using Teleperformance.Final.Project.Application.Contracts.MongoDb;
using Teleperformance.Final.Project.MongoDb.Model;

namespace Teleperformance.Final.Project.Consumer.Worker
{
    public class Worker : BackgroundService
    {
        #region FIELDS


        private readonly IMongoDbConnector _mongoDbConnector;
        private EventLog _eventLogger;

        #endregion

        #region CTOR


        public Worker(IMongoDbConnector mongoDbConnector)
        {
            _mongoDbConnector = mongoDbConnector;

            _eventLogger = new EventLog();
            _eventLogger.Source = "Application";

            _eventLogger.WriteEntry("Worker Baþladý.", EventLogEntryType.Information);

            Console.WriteLine($"{DateTime.UtcNow} >> Worker Çalýþýyor.. >> Lütfen Kapatmayýnýz");
        }

        #endregion


        #region METHODS
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            var collection = _mongoDbConnector.Connect<ShoppingListBson>();

            try
            {

                _eventLogger.WriteEntry($"Worker Çalýþmaya Baþladý: {DateTimeOffset.Now}", EventLogEntryType.Information);

                while (!stoppingToken.IsCancellationRequested)
                {
                    await Task.Delay(1000, stoppingToken);

                }



            }
            catch (Exception ex)
            {

                _eventLogger.WriteEntry($"Bir Hata meydana Geldi: {ex.Message}", EventLogEntryType.Error);
            }


        }

        #endregion
    }
}