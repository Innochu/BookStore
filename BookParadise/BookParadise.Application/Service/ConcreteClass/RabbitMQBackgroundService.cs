using BookParadise.Application.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookParadise.Application.Service.ConcreteClass
{
    public class RabbitMQBackgroundService : BackgroundService
    {
       
        private readonly IServiceProvider _serviceProvider;

        public RabbitMQBackgroundService(IServiceProvider serviceProvider)
        {
        
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using var scope = _serviceProvider.CreateScope();
                    var rabbitMQService = scope.ServiceProvider.GetRequiredService<IRabbitMQService>();
                   
                }
                catch (Exception ex)
                {
                    // Log the exception here (consider using a logging library)
                    Console.WriteLine($"Error receiving message: {ex.Message}");
                }
            }
        }
    }
}
