using Teleperformance.Final.Project.Application.Contracts.MongoDb;
using Teleperformance.Final.Project.Application.RabbitMq;
using Teleperformance.Final.Project.Consumer.Worker;
using Teleperformance.Final.Project.MessageBroker.RabbitMq.Connector;
using Teleperformance.Final.Project.MongoDb.Connector;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddTransient<IMongoDbConnector, MongoDbConnector>();
        services.AddTransient<IRabbitMqConnector, RabbitMqConnector>();
        
    })
    .Build();

await host.RunAsync();
