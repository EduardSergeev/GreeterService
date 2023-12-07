# gRPC/Protobuf code generation example

[MSDN gRPC example](https://learn.microsoft.com/en-us/aspnet/core/grpc/) implemented using [IndependentReserve.Grpc.Tools](https://www.nuget.org/packages/IndependentReserve.Grpc.Tools/#readme-body-tab) package

[![Build Status](https://github.com/EduardSergeev/GreeterService/workflows/build/badge.svg)](https://github.com/EduardSergeev/GreeterService/actions?query=workflow%3Abuild+branch%3Amaster)
[![Linux benchmarks](https://eduardsergeev.github.io/GreeterService/bench-linux.svg)](https://eduardsergeev.github.io/GreeterService/bench-linux/results/SingleDto-report.html)
[![Windows benchmarks](https://eduardsergeev.github.io/GreeterService/bench-windows.svg)](https://eduardsergeev.github.io/GreeterService/bench-windows/results/SingleDto-report.html)

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

## Benchmark results

Latest benchmark results can be found on [docs](../docs/docs) branch:
- [Linux](../docs/docs/bench-linux/results)
- [Windows](../docs/docs/bench-windows/results)

<details>
  <summary>Benchmark results example:</summary>

[Serialisation](Greeter.Bench/StringArraySerialisation.cs) of `string[]` vs `string?[]` collection (vs JSON serialisation as baseline):

<a href="https://eduardsergeev.github.io/GreeterService/bench-linux/results/StringArraySerialisation-report.html">
    <img src="https://eduardsergeev.github.io/GreeterService/bench-linux/results/StringArraySerialisation-barplot.png" height="500"/>
</a>

</details>
