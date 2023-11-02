namespace MedatR.Custom;

public static class EventExtension
{
    public static async Task<object?> Sending<TCommand>(this IMediator mediator, TCommand command) 
        where TCommand : class 
    {
        var reponse = await mediator.Send(command);

        var notification = reponse as WithMessageEvent;

        if (notification != null)
        {
            foreach (var item in notification.GetEvents())
            {
                await mediator.Publish(item).ConfigureAwait(false);
            }
        }

        return reponse;
    }
}
