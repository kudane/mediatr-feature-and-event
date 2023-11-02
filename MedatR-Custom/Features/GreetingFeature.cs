namespace MedatR.Custom;

public class GreetingFeature
{
    public class Command : IRequest<Response>
    {
        public string Message { get; set; } = null!;
    }

    public class Response : WithMessageEvent
    {
        public string GreetingText { get; set; } = null!;
    }

    public class Handler : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command command, CancellationToken cancellationToken)
        {
            var greeting = new Response { GreetingText = command.Message };

            var alermEvent = new AlarmEvent.Message(){Prop1 = command.Message};

            greeting.AddEvent(alermEvent);

            return await Task.FromResult(greeting);
        }
    }
}