
using RabbitMQ.Client;
using Teleperformance.Final.Project.Application.RabbitMq;
using Teleperformance.Final.Project.MessageBroker.RabbitMq.Configuration;

namespace Teleperformance.Final.Project.MessageBroker.RabbitMq.Connector
{
    public class RabbitMqConnector : IRabbitMqConnector
    {
        public IConnection Connect()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = RabbitMqConfiguration.HostName,
                VirtualHost = RabbitMqConfiguration.VirtualHost,
                Port = RabbitMqConfiguration.Port,
                UserName = RabbitMqConfiguration.UserName,
                Password = RabbitMqConfiguration.Password

            }.CreateConnection();

            return connectionFactory;
        }
    }
}
