using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEvents
{
    public static class DomainEvents
    {
        public static Func<IMediator> Mediator;
        public static async Task Raise<T>(T args) where T : INotification
        {
            var mediator = Mediator.Invoke();
            await mediator.Publish<T>(args);
        }
    }
}
