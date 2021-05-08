using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Infra.Bus
{
    public sealed class RabbitMQBus : IEventBus
    {
        public void Publish<T>(T @event) where T : Event
        {
            throw new System.NotImplementedException();
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            throw new System.NotImplementedException();
        }

        public void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>
        {
            throw new System.NotImplementedException();
        }
    }
}