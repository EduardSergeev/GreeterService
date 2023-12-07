```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 3.873 μs | 0.9208 μs | 0.0505 μs | 0.1450 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.085 μs | 0.1727 μs | 0.0095 μs | 0.0610 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 6.806 μs | 0.4658 μs | 0.0255 μs | 0.3433 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.240 μs | 0.8619 μs | 0.0472 μs | 0.2060 |   3.46 KB |
