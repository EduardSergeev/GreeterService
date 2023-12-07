```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.607 μs | 0.0052 μs | 0.0046 μs | 0.1450 |      - |    2448 B |
| &#39;Proto → byte[]&#39; | 2.077 μs | 0.0108 μs | 0.0090 μs |      - |      - |         - |
| &#39;byte[] → Proto&#39; | 1.843 μs | 0.0141 μs | 0.0125 μs | 0.1965 | 0.0019 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.376 μs | 0.0315 μs | 0.0279 μs | 0.1526 |      - |    2560 B |
