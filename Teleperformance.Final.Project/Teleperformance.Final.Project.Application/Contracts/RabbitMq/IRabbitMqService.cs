namespace Teleperformance.Final.Project.Application.Contracts.RabbitMq
{
    public interface IRabbitMqService
    {

        void Publish<T>(T value, string exchangeType, string exchangeName, string queueName, string? routeKey);

    }
}
