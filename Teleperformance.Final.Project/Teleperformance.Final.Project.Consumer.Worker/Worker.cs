using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using Teleperformance.Final.Project.Application.Contracts.MongoDb;
using Teleperformance.Final.Project.Application.RabbitMq;
using Teleperformance.Final.Project.MongoDb.Model;

namespace Teleperformance.Final.Project.Consumer.Worker
{
    public class Worker : BackgroundService
    {
        #region FIELDS


        private readonly IMongoDbConnector _mongoDbConnector;
        private readonly IRabbitMqConnector _rabbitMqConnector;
        private EventLog _eventLogger;

        #endregion

        #region CTOR


        public Worker(IMongoDbConnector mongoDbConnector, IRabbitMqConnector rabbitMqConnector)
        {

            _rabbitMqConnector = rabbitMqConnector;
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

                    var connection = _rabbitMqConnector.Connect();
                    var channel = connection.CreateModel();
                    channel.QueueDeclare("direct.queuName", false, false, false);
                    var consumer = new EventingBasicConsumer(channel);


                    consumer.Received += async (sender, args) =>
                    {
                        var message = JsonSerializer.Deserialize<ShoppingListBson>(Encoding.UTF8.GetString(args.Body.ToArray()));


                        await collection.InsertOneAsync(message);
                    };

                    channel.BasicConsume("direct.queuName", false, consumer);
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