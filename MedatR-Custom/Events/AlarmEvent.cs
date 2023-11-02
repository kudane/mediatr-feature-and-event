namespace MedatR.Custom;

public class AlarmEvent
{
    public class Message : MessageEvent
    {
        public string Prop1 { get; set; } = null!;
    }

    public class Handler : INotificationHandler<Message>
    {
        public Task Handle(Message notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"{notification.Prop1}");
            return Task.CompletedTask;
        }
    }
}
