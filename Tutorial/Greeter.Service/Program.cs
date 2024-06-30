using Greeter.Common;
using Greeter.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();
builder.Services.AddScoped<IGreeterService, GreeterService>();
    
var app = builder.Build();
app.MapGrpcService<Greeter.Common.Grpc.GreeterServiceGrpcService>();

app.Run();
