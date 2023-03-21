using Greeter.Common;
using Greeter.Common.Grpc;
using static System.Reflection.Assembly;

namespace Greeter.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services
            .AddSingleton(GetExecutingAssembly().GetName().Version ?? new Version())
            .AddScoped<IGreeterService, Greeter>()
            .AddScoped<IGreeterExtendedService, GreeterExtended>()
            .AddGrpc();

        var app = builder.Build();
        app.Logger.LogInformation($"Version {app.Services.GetService<Version>()}");
        app.MapGrpcService<GreeterServiceGrpcService>();
        app.MapGrpcService<GreeterExtendedServiceGrpcService>();
        app.Run();
    }
}
