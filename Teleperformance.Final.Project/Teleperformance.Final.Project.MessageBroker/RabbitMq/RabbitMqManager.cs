using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using Teleperformance.Final.Project.Application.Contracts.RabbitMq;
using Teleperformance.Final.Project.MessageBroker.RabbitMq.Configuration;

namespace Teleperformance.Final.Project.MessageBroker.RabbitMq
{
    public class RabbitMqManager : IRabbitMqService,IDisposable
    {
        #region FIELDS
        private ConnectionFactory connectionFactory;
        private IConnection _connection;
        private IModel _channel;
        #endregion

        #region METHODS
        public IConnection Connect()
        {
            connectionFactory = new ConnectionFactory()
            {
                HostName = RabbitMqConfiguration.HostName,
                VirtualHost = RabbitMqConfiguration.VirtualHost,
                Port = RabbitMqConfiguration.Port,
                UserName = RabbitMqConfiguration.UserName,
                Password = RabbitMqConfiguration.Password

            };

            return connectionFactory.CreateConnection();
        }
        
        public void Publish<T>(T value, string exchangeType, string exchangeName, string queueName, string? routeKey)
        {
            var connection = Connect();

            var channel = connection.CreateModel();

            channel.ExchangeDeclare(exchangeName, exchangeType, false, false);

            channel.QueueDeclare(queueName, false, false, false);

            channel.QueueBind(queueName, exchangeName, routeKey);

            var message = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(value));

            channel.BasicPublish(exchangeName, routeKey, null, message);
        }

        public void Dispose()
        {
            _channel.Close();
            _connection.Close();
            Dispose();

        }

        #endregion

    }
}
