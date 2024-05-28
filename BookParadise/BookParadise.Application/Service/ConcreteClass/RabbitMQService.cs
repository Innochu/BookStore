using BookParadise.Application.Service.Interface;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace BookParadise.Application.Service.ConcreteClass
{
    public class RabbitMQService : IRabbitMQService
    {
        private readonly string _hostName;
        private readonly string _userName;
        private readonly string _password;
        public IConnection _connection;

        public RabbitMQService()
        {
            _hostName = "localhost";
            _userName = "guest";
            _password = "guest";
        }
        public void SendMessage(string message, string QueueName)
        {
            var factory = new ConnectionFactory
            {
                HostName = _hostName,
                UserName = _userName,
                Password = _password,
            };
            _connection = factory.CreateConnection();
            using var channel = _connection.CreateModel();
            channel.QueueDeclare(QueueName);
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);
            channel.BasicPublish(exchange: "", routingKey: QueueName, body: body);
        }
      
    }
}
