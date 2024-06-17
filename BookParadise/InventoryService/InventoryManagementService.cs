//using Microsoft.AspNetCore.Connections;

//namespace InventoryService
//{
//    public class InventoryManagementService : BackgroundService
//    {
//        private readonly IConfiguration _configuration;
//        private readonly IOrderService _orderService;
//        private IConnection _connection;
//        private IModel _channel;

//        public RabbitMQReceiverService(IConfiguration configuration, IOrderService orderService)
//        {
//            _configuration = configuration;
//            _orderService = orderService;
//            var factory = new ConnectionFactory
//            {
//                HostName = "localhost",
//                UserName = "guest",
//                Password = "guest",
//            };
//            _connection = factory.CreateConnection();
//            _channel = _connection.CreateModel();
//            _channel.QueueDeclare(queue: "orders", durable: false, exclusive: false, autoDelete: false, arguments: null);
//        }


//        protected override Task ExecuteAsync(CancellationToken stoppingToken)
//        {
//            stoppingToken.ThrowIfCancellationRequested();
//            var consumer = new EventingBasicConsumer(_channel);
//            consumer.Received += (model, ea) =>
//            {
//                var body = ea.Body.ToArray();
//                var message = Encoding.UTF8.GetString(body);
//                OrderRequestDTO orderDTO = JsonConvert.DeserializeObject<OrderRequestDTO>(message);
//                ReceiveMessage(orderDTO).GetAwaiter().GetResult();
//                _channel.BasicAck(ea.DeliveryTag, false);
//            };
//            _channel.BasicConsume("order", false, consumer);
//            return Task.CompletedTask;
//        }

//        private async Task ReceiveMessage(OrderRequestDTO orderDTO)
//        {
//            try
//            {
//                // Call the injected IOrderService to place the order
//                var placedOrderResponse = await _orderService.PlaceOrderAsync(orderDTO);

//                if (placedOrderResponse.IsSuccess)
//                {
//                    Console.WriteLine($"Order placed successfully! Order ID: {placedOrderResponse.Data.Id}");
//                }
//                else
//                {
//                    Console.WriteLine($"Failed to place order:");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error processing order: {ex.Message}");
//            }
//        }
//    }
//}
