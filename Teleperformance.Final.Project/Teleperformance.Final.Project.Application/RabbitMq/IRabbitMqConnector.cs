

using RabbitMQ.Client;

namespace Teleperformance.Final.Project.Application.RabbitMq
{
    public interface IRabbitMqConnector
    {
        IConnection Connect();

    }
}
