```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 4.014 μs | 0.0195 μs | 0.0183 μs | 0.1450 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.026 μs | 0.0078 μs | 0.0073 μs | 0.0610 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 6.528 μs | 0.0159 μs | 0.0149 μs | 0.3433 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.322 μs | 0.0224 μs | 0.0209 μs | 0.2060 |   3.46 KB |
