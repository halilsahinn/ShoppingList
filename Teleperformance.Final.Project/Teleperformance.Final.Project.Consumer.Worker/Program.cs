using Teleperformance.Final.Project.Application.Contracts.MongoDb;
using Teleperformance.Final.Project.Consumer.Worker;
using Teleperformance.Final.Project.MongoDb.Connector;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddTransient<IMongoDbConnector, MongoDbConnector>();
      // services.AddTransient<IRabbitmqConnection, RabbitmqConnection>();
        
    })
    .Build();

await host.RunAsync();
