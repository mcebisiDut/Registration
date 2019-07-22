using Common.IEvents;

namespace Common.Events
{
    public class RegistrationFailure : IRegistrationFailure
    {
        public string Email { get; }
        public string Message { get; }
        public string Code { get; }

        protected RegistrationFailure()
        {
        }

        public RegistrationFailure(string email, string message, string code)
        {
            Email = email;
            Message = message;
            Code = code;
        }
    }
}