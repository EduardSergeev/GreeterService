```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2529) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.713 μs | 0.0070 μs | 0.0066 μs | 0.1450 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.060 μs | 0.0052 μs | 0.0048 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 1.936 μs | 0.0096 μs | 0.0080 μs | 0.1945 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.281 μs | 0.0184 μs | 0.0144 μs | 0.1526 |    2560 B |
