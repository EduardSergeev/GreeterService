```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;byte[] → Proto&#39; | 1.983 μs | 0.3100 μs | 0.0170 μs | 0.1945 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.436 μs | 1.1747 μs | 0.0644 μs | 0.1526 |    2560 B |
| &#39;DTO → Proto&#39;    | 1.733 μs | 0.2076 μs | 0.0114 μs | 0.1450 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.180 μs | 0.1083 μs | 0.0059 μs |      - |       7 B |
