using Greeter.Common;
using Greeter.Common.Grpc;

namespace Greeter.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services
            .AddScoped<IGreeterService, Greeter>()
            .AddScoped<IGreeterExtendedService, GreeterExtended>()
            .AddGrpc();

        var app = builder.Build();
        app.MapGrpcService<GreeterServiceGrpcService>();
        app.MapGrpcService<GreeterExtendedServiceGrpcService>();
        app.Run();
    }
}
