```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 4.381 μs | 0.0061 μs | 0.0051 μs | 0.0229 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.109 μs | 0.0355 μs | 0.0332 μs | 0.0076 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 7.212 μs | 0.0094 μs | 0.0084 μs | 0.0687 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.210 μs | 0.0107 μs | 0.0100 μs | 0.0381 |   3.46 KB |
