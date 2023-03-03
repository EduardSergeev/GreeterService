# gRPC/Protobuf code generation example

[MSDN gRPC example](https://learn.microsoft.com/en-us/aspnet/core/grpc/) implemented with [IndependentReserve.Grpc.Tools](https://www.nuget.org/packages/IndependentReserve.Grpc.Tools#readme-body-tab)

[![Build Status](https://github.com/EduardSergeev/GreeterService/workflows/build/badge.svg)](https://github.com/EduardSergeev/GreeterService/actions?query=workflow%3Abuild+branch%3Amaster)


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
docker build -t greeter -f Greeter.Service/Dockerfile .
docker run -it --rm -p 5001:443 greeter
```
