```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.877 μs | 0.0117 μs | 0.0097 μs | 0.0267 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.281 μs | 0.0049 μs | 0.0041 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 2.363 μs | 0.0123 μs | 0.0109 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.507 μs | 0.0179 μs | 0.0158 μs | 0.0305 |    2560 B |
