using System;
using System.Threading.Tasks;
using Common.Events;
using Common.IEvents;
using Microsoft.Extensions.Logging;

namespace Sales.Api.Handlers
{
    public class UserRegisteredHandler : IEventHandler<UserRegistered>
    {
        private readonly ILogger _logger;

        public UserRegisteredHandler(ILogger logger)
        {
            _logger = logger;
        }
        public async Task HandleAsync(UserRegistered @event)
        {
            await Task.CompletedTask;
            _logger.LogInformation($"User registered: {@event.FirstName}");
        }
    }
}