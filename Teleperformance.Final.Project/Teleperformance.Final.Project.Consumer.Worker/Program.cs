using Teleperformance.Final.Project.Application.Contracts.MongoDb;
using Teleperformance.Final.Project.Application.Contracts.RabbitMq;
using Teleperformance.Final.Project.Consumer.Worker;
using Teleperformance.Final.Project.MessageBroker.RabbitMq;
using Teleperformance.Final.Project.MongoDb.Connector;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddTransient<IMongoDbService, MongoDbConnector>();
        services.AddTransient<IRabbitMqService, RabbitMqManager>();

    })
    .Build();

await host.RunAsync();
