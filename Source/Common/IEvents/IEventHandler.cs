using System.Threading.Tasks;

namespace Common.IEvents
{
    public interface IEventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T @event);
    }
}