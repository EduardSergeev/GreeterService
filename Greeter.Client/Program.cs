using Greater.Common.Grpc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static System.Console;

using var host = Host.CreateDefaultBuilder(args).Build();
var config = host.Services
    .GetRequiredService<IConfiguration>()
    .GetRequiredSection("GreeterService")
    .Get<GrpcConfiguration>();

var client = new GreeterServiceGrpcClient(config, false);

WriteLine(client.SayHello("World"));
WriteLine(await client.SayHelloAsync("Async"));
