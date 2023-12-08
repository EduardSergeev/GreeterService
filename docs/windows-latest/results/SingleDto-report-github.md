```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 3.988 μs | 0.0075 μs | 0.0070 μs | 0.1450 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.003 μs | 0.0081 μs | 0.0068 μs | 0.0610 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 6.668 μs | 0.0434 μs | 0.0406 μs | 0.3433 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.190 μs | 0.0123 μs | 0.0115 μs | 0.2060 |   3.46 KB |
