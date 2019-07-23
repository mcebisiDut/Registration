using System;

namespace Common.Exceptions
{
    public class RegistrationException : Exception
    {
        public string Code { get; }
        public RegistrationException()
        {
        }

        public RegistrationException(string code):base(code)
        {
            Code = code;
        }
    }
}