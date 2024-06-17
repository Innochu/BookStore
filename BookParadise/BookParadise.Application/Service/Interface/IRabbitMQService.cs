namespace BookParadise.Application.Service.Interface
{
    public interface IRabbitMQService
    {
        void SendMessage(string message, string QueueName);
        void ReceiveMessage(string queueName, Action<string> messageHandler);
        //Task ReceiveMessage(string QueueName);
    }

}
