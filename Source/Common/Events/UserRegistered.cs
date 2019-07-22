using Common.IEvents;

namespace Common.Events
{
    public class UserRegistered : IEvent
    {
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }

        protected UserRegistered()
        {
        }

        public UserRegistered(string email, string name, string surname)
        {
            Email = email;
            FirstName = name;
            LastName = surname;
        }
    }
}