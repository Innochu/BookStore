using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Application.Service.Interface
{
    public interface IRabbitMQService
    {
        void SendMessage(string message, string QueueName);
    }
}
