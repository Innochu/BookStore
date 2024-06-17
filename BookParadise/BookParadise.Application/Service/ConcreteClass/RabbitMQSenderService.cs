using BookParadise.Application.Service.Interface;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace BookParadise.Application.Service.ConcreteClass
{
    public class RabbitMQSenderService : IRabbitMQService
    {
        private readonly string _hostName;
        private readonly string _userName;
        private readonly string _password;

        public IConnection _connection;

        public RabbitMQSenderService()
        {
            _hostName = "localhost";
            _userName = "guest";
            _password = "guest";
        
        }
        public void SendMessage(string message, string QueueName)
        {
            if (ConnectionExists())
            {
                using var channel = _connection.CreateModel();

                channel.QueueDeclare(queue: QueueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

                var json = JsonConvert.SerializeObject(message);
                var body = Encoding.UTF8.GetBytes(json);
                channel.ExchangeDeclare("myExchange", ExchangeType.Direct);
                channel.BasicPublish(exchange: "myExchange", routingKey: QueueName, body: body);
              
            }
        }
        public void ReceiveMessage(string QueueName, Action<string> messageHandler)
        {
            if (ConnectionExists())
            {
                using var channel = _connection.CreateModel();

                channel.QueueDeclare(queue: QueueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

                var consumer = new AsyncEventingBasicConsumer(channel);
                consumer.Received += async (model, ea) =>
                {
                    try
                    {
                        var body = ea.Body.ToArray();
                        var message = Encoding.UTF8.GetString(body);

                        Console.WriteLine($"Received message: {message}"); // Log received message

                        messageHandler.Invoke(message);

                        Console.WriteLine($"Processed message: {message}"); // Log processed message
                    }
                    catch (Exception ex)
                    {
                        var body = ea.Body.ToArray();
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine($"Error processing message: {message}"); // Log error with message
                        Console.WriteLine(ex.Message); // Log exception details
                    }
                };

                channel.BasicConsume(queue: QueueName, autoAck: true, consumer: consumer);
            }
        }




        private void CreateConnection()
        {

            var factory = new ConnectionFactory
            {
                HostName = _hostName,
                UserName = _userName,
                Password = _password,
            };
            _connection = factory.CreateConnection();
        }
            
        private bool ConnectionExists()
        {
            if (_connection != null)
            {
                return true;
            }
            CreateConnection();
            return true;
        }
    }
}
