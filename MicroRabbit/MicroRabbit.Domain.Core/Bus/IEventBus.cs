using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;         // @event is a reserved keyword in c#
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
