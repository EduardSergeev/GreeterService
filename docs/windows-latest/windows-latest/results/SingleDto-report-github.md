```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 4.034 μs | 0.0064 μs | 0.0050 μs | 0.1450 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.012 μs | 0.0088 μs | 0.0078 μs | 0.0610 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 6.505 μs | 0.0268 μs | 0.0224 μs | 0.3433 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.381 μs | 0.0302 μs | 0.0268 μs | 0.2060 |   3.46 KB |
