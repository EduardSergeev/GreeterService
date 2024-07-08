```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → byte[]&#39; | 4.341 μs | 0.0197 μs | 0.0184 μs | 0.0229 |   2.39 KB |
| &#39;DTO → JSON&#39;   | 5.085 μs | 0.0167 μs | 0.0156 μs | 0.0076 |   1.06 KB |
| &#39;byte[] → DTO&#39; | 7.453 μs | 0.0256 μs | 0.0227 μs | 0.0687 |   5.72 KB |
| &#39;JSON → DTO&#39;   | 7.415 μs | 0.0217 μs | 0.0181 μs | 0.0381 |   3.46 KB |