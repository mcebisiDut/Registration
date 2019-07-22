namespace Common.IEvents
{
    public interface IRegistrationFailure
    {
        string Message { get; }
        string Code { get; }
    }
}