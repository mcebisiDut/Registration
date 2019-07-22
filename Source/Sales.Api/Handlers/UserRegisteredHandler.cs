using System;
using System.Threading.Tasks;
using Common.Events;
using Common.IEvents;

namespace Sales.Api.Handlers
{
    public class UserRegisteredHandler : IEventHandler<UserRegistered>
    {
        public async Task HandleAsync(UserRegistered @event)
        {
            await Task.CompletedTask;
            Console.WriteLine($"User registered: {@event.FirstName}");
        }
    }
}