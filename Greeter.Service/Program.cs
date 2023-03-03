using Greeter.Common;
using Greeter.Common.Grpc;
using Greeter.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddScoped<IGreeterService, GreeterImpl>()
    .AddScoped<IGreeterExtendedService, GreeterImpl>()
    .AddGrpc();

var app = builder.Build();
app.MapGrpcService<GreeterServiceGrpcService>();
app.MapGrpcService<GreeterExtendedServiceGrpcService>();
app.Run();
