using System;
using System.Threading.Tasks;
using Common.Events;
using Common.Exceptions;
using Common.IEvents;
using Microsoft.Extensions.Logging;
using RawRabbit;

namespace Sales.Api.Handlers
{
    public class UserRegisteredHandler : IEventHandler<UserRegistered>
    {
        private readonly IBusClient _bus;
        private readonly ILogger<UserRegisteredHandler> _logger;

        public UserRegisteredHandler(IBusClient bus,ILogger<UserRegisteredHandler> logger)
        {
            _bus = bus;
            _logger = logger;
        }
        public async Task HandleAsync(UserRegistered @event)
        {
            try
            {
                await Task.CompletedTask;
                _logger.LogInformation($"User registered: {@event.FirstName}");
            }
            catch (RegistrationException exception)
            {
                await _bus.PublishAsync(new RegistrationFailure(@event.Email,exception.Code, exception.Message));
                _logger.LogError(exception.Message);
            }
        }
    }
}