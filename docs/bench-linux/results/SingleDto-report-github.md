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
| &#39;DTO → byte[]&#39; | 4.390 μs | 0.0885 μs | 0.0049 μs | 0.0229 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 4.982 μs | 0.5312 μs | 0.0291 μs | 0.0076 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 7.384 μs | 0.2434 μs | 0.0133 μs | 0.0687 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.242 μs | 0.4486 μs | 0.0246 μs | 0.0381 |   3.46 KB |