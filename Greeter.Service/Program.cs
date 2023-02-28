using Greeter.Common;
using Greeter.Common.Grpc;
using Greeter.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddScoped<IGreeterService, GreeterImpl>()
    .AddGrpc();

var app = builder.Build();
app.MapGrpcService<GreeterServiceGrpcService>();
app.Run();
