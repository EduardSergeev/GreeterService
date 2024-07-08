```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.987 μs | 0.0087 μs | 0.0081 μs | 0.0267 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.213 μs | 0.0083 μs | 0.0074 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 2.244 μs | 0.0054 μs | 0.0042 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.456 μs | 0.0286 μs | 0.0267 μs | 0.0305 |    2560 B |
