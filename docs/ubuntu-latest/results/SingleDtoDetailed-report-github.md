```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.890 μs | 0.0054 μs | 0.0045 μs | 0.0286 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.229 μs | 0.0237 μs | 0.0222 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 2.204 μs | 0.0178 μs | 0.0166 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.596 μs | 0.0319 μs | 0.0298 μs | 0.0305 |    2560 B |
