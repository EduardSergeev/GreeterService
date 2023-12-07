```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.931 μs | 0.0038 μs | 0.0030 μs | 0.0267 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.240 μs | 0.0122 μs | 0.0114 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 2.232 μs | 0.0087 μs | 0.0077 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.531 μs | 0.0070 μs | 0.0055 μs | 0.0305 |    2560 B |
