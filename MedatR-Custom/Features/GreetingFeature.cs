namespace MedatR.Custom;

public class GreetingFeature
{
    public class Command : IRequest<string>
    {
        public string Message { get; set; } = null!;
    }

    public class Handler : IRequestHandler<Command, string>
    {
        public async Task<string> Handle(Command command, CancellationToken cancellationToken)
        {
            return await Task.FromResult(command.Message);
        }
    }
}