```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2529) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 3.851 μs | 0.0121 μs | 0.0101 μs | 0.1450 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 4.834 μs | 0.0166 μs | 0.0155 μs | 0.0610 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 6.638 μs | 0.0559 μs | 0.0523 μs | 0.3433 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.285 μs | 0.0093 μs | 0.0087 μs | 0.2060 |   3.46 KB |
