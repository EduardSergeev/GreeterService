```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| &#39;DTO → Proto&#39;    | 2.007 μs | 0.0075 μs | 0.0067 μs | 0.0267 |    2448 B |
| &#39;Proto → byte[]&#39; | 2.249 μs | 0.0067 μs | 0.0056 μs |      - |         - |
| &#39;byte[] → Proto&#39; | 2.187 μs | 0.0082 μs | 0.0073 μs | 0.0381 |    3296 B |
| &#39;Proto → DTO&#39;    | 4.422 μs | 0.0114 μs | 0.0095 μs | 0.0305 |    2560 B |
