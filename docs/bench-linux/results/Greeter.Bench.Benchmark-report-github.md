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
| &#39;byte[] → DTO&#39; | 7.492 μs | 1.4378 μs | 0.0788 μs | 0.0687 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.374 μs | 0.1031 μs | 0.0057 μs | 0.0381 |   3.46 KB |
| &#39;DTO → byte[]&#39; | 4.528 μs | 0.2137 μs | 0.0117 μs | 0.0229 |    2.4 KB |
| &#39;DTO → JSON&#39;   | 5.073 μs | 0.7380 μs | 0.0405 μs | 0.0076 |   1.06 KB |
