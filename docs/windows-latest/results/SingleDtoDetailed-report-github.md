```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.536 μs | 0.0039 μs | 0.0037 μs | 0.1450 |      - |    2448 B |
| &#39;Proto → byte[]&#39; | 2.075 μs | 0.0053 μs | 0.0047 μs |      - |      - |         - |
| &#39;byte[] → Proto&#39; | 1.865 μs | 0.0052 μs | 0.0048 μs | 0.1965 | 0.0019 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.250 μs | 0.0051 μs | 0.0043 μs | 0.1526 |      - |    2560 B |
