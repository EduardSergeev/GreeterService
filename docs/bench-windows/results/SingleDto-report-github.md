```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Mean     | Error      | StdDev    | Gen0   | Allocated |
|--------------- |---------:|-----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 5.039 μs | 28.9373 μs | 1.5861 μs | 0.1450 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.011 μs |  0.1411 μs | 0.0077 μs | 0.0610 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 6.954 μs |  0.0217 μs | 0.0012 μs | 0.3433 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.235 μs |  0.1801 μs | 0.0099 μs | 0.2060 |   3.46 KB |
