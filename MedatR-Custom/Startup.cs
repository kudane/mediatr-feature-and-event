namespace MedatR.Custom;

public static class Startup
{
    public static IServiceCollection AddCustomService(this IServiceCollection services)
    {
        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            //...
        });

        return services;
    }
}