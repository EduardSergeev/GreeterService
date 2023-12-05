```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method               | Length | Mean         | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|--------------------- |------- |-------------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| **DtoSerialize**         | **10**     |     **530.3 ns** |  **3.29 ns** |  **3.07 ns** |  **1.15** |    **0.01** | **0.0038** |     **360 B** |        **0.74** |
| JsonSerialize        | 10     |     462.5 ns |  2.36 ns |  2.10 ns |  1.00 |    0.00 | 0.0057 |     488 B |        1.00 |
| NullableDtoSerialize | 10     |   1,496.3 ns |  4.46 ns |  4.17 ns |  3.23 |    0.02 | 0.0076 |     680 B |        1.39 |
|                      |        |              |          |          |       |         |        |           |             |
| **DtoSerialize**         | **100**    |   **3,585.6 ns** | **11.52 ns** | **10.78 ns** |  **1.37** |    **0.01** | **0.0229** |    **2225 B** |        **4.56** |
| JsonSerialize        | 100    |   2,611.5 ns | 11.12 ns | 10.40 ns |  1.00 |    0.00 | 0.0038 |     488 B |        1.00 |
| NullableDtoSerialize | 100    |  13,034.1 ns | 39.55 ns | 37.00 ns |  4.99 |    0.02 | 0.0610 |    5426 B |       11.12 |
|                      |        |              |          |          |       |         |        |           |             |
| **DtoSerialize**         | **1000**   |  **33,801.6 ns** | **70.95 ns** | **59.25 ns** |  **1.27** |    **0.00** | **0.1831** |   **16655 B** |       **34.13** |
| JsonSerialize        | 1000   |  26,683.0 ns | 85.59 ns | 80.06 ns |  1.00 |    0.00 |      - |     488 B |        1.00 |
| NullableDtoSerialize | 1000   | 126,913.3 ns | 87.96 ns | 73.45 ns |  4.76 |    0.02 | 0.4883 |   48655 B |       99.70 |
