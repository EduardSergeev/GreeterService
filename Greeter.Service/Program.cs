using Greater.Common;
using Greater.Common.Grpc;
using Greater.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddScoped<IGreeterService, Greeter>()
    .AddGrpc();

var app = builder.Build();
app.MapGrpcService<GreeterServiceGrpcService>();
app.Run();
