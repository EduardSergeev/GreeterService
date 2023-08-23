# gRPC/Protobuf code generation example

[MSDN gRPC example](https://learn.microsoft.com/en-us/aspnet/core/grpc/) implemented with [![IndependentReserve.Grpc.Tools](https://img.shields.io/nuget/dt/IndependentReserve.Grpc.Tools?logo=nuget&label=IndependentReserve.Grpc.Tools&labelColor=%23004880&link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FIndependentReserve.Grpc.Tools%23readme-body-tab)](https://www.nuget.org/packages/IndependentReserve.Grpc.Tools/#readme-body-tab)


[![Build Status](https://github.com/EduardSergeev/GreeterService/workflows/build/badge.svg)](https://github.com/EduardSergeev/GreeterService/actions?query=workflow%3Abuild+branch%3Amaster)
[![Linux benchmarks](https://eduardsergeev.github.io/GreeterService/bench-linux.svg)](https://eduardsergeev.github.io/GreeterService/bench-linux/results/Greeter.Bench.Benchmark-report.html)
[![Windows benchmarks](https://eduardsergeev.github.io/GreeterService/bench-windows.svg)](https://eduardsergeev.github.io/GreeterService/bench-windows/results/Greeter.Bench.Benchmark-report.html)



## How to run it

Server:

```console
cd Greeter.Service
dotnet run
```

Client:

```console
cd Greeter.Client
dotnet run
```

Tests:

```console
cd Greeter.Test
dotnet test
```

Docker:

```console
docker build -t greeter-service -f Greeter.Service/Dockerfile .
docker run -it --rm -p 5001:443 greeter-service
```

Benchmarks:

```console
cd Greeter.Bench
dotnet run -c Release
```
