```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 4.272 μs | 0.0267 μs | 0.0249 μs | 0.0229 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.020 μs | 0.0342 μs | 0.0303 μs | 0.0076 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 7.456 μs | 0.0257 μs | 0.0240 μs | 0.0687 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.277 μs | 0.0670 μs | 0.0626 μs | 0.0381 |   3.46 KB |
