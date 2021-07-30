using MediatR;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace DomainEvents
{
    public class UpdateForecastEvent : INotification {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }

    public class UpdateForecastEventHandler : INotificationHandler<UpdateForecastEvent>
    {
        public Task Handle(UpdateForecastEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"ChangeTemperatureEvent: DateTime: {notification.Date}, Temp: {notification.TemperatureC}, Summary: {notification.Summary}");
            return Task.CompletedTask;
        }
    }
}
