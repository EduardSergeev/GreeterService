```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 4.571 μs | 1.3725 μs | 0.0752 μs | 0.0229 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.122 μs | 0.4309 μs | 0.0236 μs | 0.0076 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 7.756 μs | 0.0944 μs | 0.0052 μs | 0.0610 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.348 μs | 0.7148 μs | 0.0392 μs | 0.0381 |   3.46 KB |