using System.Threading.Tasks;

namespace Common.ICommands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}