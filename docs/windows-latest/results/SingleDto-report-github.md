```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 3.912 μs | 0.0266 μs | 0.0249 μs | 0.1450 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 4.900 μs | 0.0070 μs | 0.0062 μs | 0.0610 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 6.492 μs | 0.0101 μs | 0.0089 μs | 0.3433 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.051 μs | 0.0156 μs | 0.0146 μs | 0.2060 |   3.46 KB |
