```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;byte[] → Proto&#39; | 2.198 μs | 0.1187 μs | 0.0065 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.537 μs | 2.9781 μs | 0.1632 μs | 0.0305 |    2560 B |
| &#39;DTO → Proto&#39;    | 1.893 μs | 0.1165 μs | 0.0064 μs | 0.0286 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.366 μs | 0.5309 μs | 0.0291 μs |      - |       7 B |
