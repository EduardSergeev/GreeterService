```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.677 μs | 0.0129 μs | 0.0114 μs | 0.1450 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.071 μs | 0.0030 μs | 0.0024 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 1.980 μs | 0.0147 μs | 0.0130 μs | 0.1945 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.404 μs | 0.0213 μs | 0.0166 μs | 0.1526 |    2560 B |
