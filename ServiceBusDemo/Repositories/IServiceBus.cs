using ServiceBusDemo.Models;
using System;

namespace ServiceBusDemo.Repositories
{
    public interface IServiceBus
    {
        Task SendMessageAsync(CarDetails carDetails);
    }
}
