using Common.ICommands;

namespace Common.Commands
{
    public class RegisterUser : ICommand
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}