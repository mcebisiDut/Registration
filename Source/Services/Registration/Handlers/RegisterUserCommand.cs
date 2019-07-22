using System;
using System.Threading.Tasks;
using Common.Commands;
using Common.Events;
using Common.ICommands;
using RawRabbit;

namespace Registration.Handlers {
    public class RegisterUserCommand : ICommandHandler<RegisterUser> {
        private readonly IBusClient _bus;

        public RegisterUserCommand (IBusClient bus) {
            _bus = bus;
        }
        public async Task HandleAsync (RegisterUser command) {
            Console.WriteLine($"Registering user: {command.FirstName}");
            await _bus.PublishAsync(new UserRegistered(command.Email,command.FirstName,command.LastName));
        }
    }
}