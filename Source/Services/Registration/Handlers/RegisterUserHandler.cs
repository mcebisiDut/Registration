using System;
using System.Threading.Tasks;
using Common.Commands;
using Common.Events;
using Common.Exceptions;
using Common.ICommands;
using Microsoft.Extensions.Logging;
using RawRabbit;

namespace Registration.Handlers
{
    public class RegisterUserHandler : ICommandHandler<RegisterUser>
    {
        private readonly IBusClient _bus;
        private readonly ILogger _logger;
        public RegisterUserHandler(IBusClient bus, ILogger<RegisterUserHandler> logger)
        {
            _bus = bus;
            _logger = logger;
        }
        public async Task HandleAsync(RegisterUser command)
        {
            _logger.LogInformation($"Registering user: {command.FirstName}");
            try
            {
                await _bus.PublishAsync(new UserRegistered(command.Email, command.FirstName, command.LastName));
                _logger.LogInformation($"User: {command.FirstName} was registered");

                return;
            }
            catch (RegistrationException exception)
            {
                await _bus.PublishAsync(new RegistrationFailure(command.Email,exception.Code, exception.Message));
                _logger.LogError(exception.Message);
            }
        }
    }
}