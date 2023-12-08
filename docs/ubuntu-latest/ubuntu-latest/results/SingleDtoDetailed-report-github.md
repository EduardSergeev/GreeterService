```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 2.044 μs | 0.0097 μs | 0.0086 μs | 0.0267 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.237 μs | 0.0028 μs | 0.0022 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 2.225 μs | 0.0090 μs | 0.0076 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.690 μs | 0.0042 μs | 0.0032 μs | 0.0305 |    2560 B |
