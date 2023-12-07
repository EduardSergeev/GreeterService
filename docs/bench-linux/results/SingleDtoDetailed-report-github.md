```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.956 μs | 0.0132 μs | 0.0110 μs | 0.0267 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.278 μs | 0.0115 μs | 0.0108 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 2.220 μs | 0.0058 μs | 0.0052 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.503 μs | 0.0141 μs | 0.0125 μs | 0.0305 |    2560 B |
