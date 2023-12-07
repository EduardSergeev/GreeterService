```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 1.970 μs | 0.0167 μs | 0.0148 μs | 0.0267 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.275 μs | 0.0162 μs | 0.0151 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 2.179 μs | 0.0182 μs | 0.0170 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.766 μs | 0.0160 μs | 0.0149 μs | 0.0305 |    2560 B |
