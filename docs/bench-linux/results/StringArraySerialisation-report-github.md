```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method               | Length | Mean         | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|--------------------- |------- |-------------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| **DtoSerialize**         | **10**     |     **533.1 ns** |   **3.11 ns** |   **2.59 ns** |  **1.10** |    **0.01** | **0.0038** |     **360 B** |        **0.74** |
| JsonSerialize        | 10     |     485.8 ns |   1.02 ns |   0.90 ns |  1.00 |    0.00 | 0.0057 |     488 B |        1.00 |
| NullableDtoSerialize | 10     |   1,495.8 ns |   6.71 ns |   5.61 ns |  3.08 |    0.01 | 0.0076 |     680 B |        1.39 |
|                      |        |              |           |           |       |         |        |           |             |
| **DtoSerialize**         | **100**    |   **3,615.0 ns** |   **7.45 ns** |   **6.60 ns** |  **1.37** |    **0.01** | **0.0229** |    **2225 B** |        **4.56** |
| JsonSerialize        | 100    |   2,648.8 ns |  16.18 ns |  15.14 ns |  1.00 |    0.00 | 0.0038 |     488 B |        1.00 |
| NullableDtoSerialize | 100    |  12,968.5 ns |  19.59 ns |  16.36 ns |  4.90 |    0.03 | 0.0610 |    5426 B |       11.12 |
|                      |        |              |           |           |       |         |        |           |             |
| **DtoSerialize**         | **1000**   |  **33,875.8 ns** | **160.81 ns** | **150.42 ns** |  **1.27** |    **0.01** | **0.1831** |   **16655 B** |       **34.13** |
| JsonSerialize        | 1000   |  26,690.5 ns | 104.54 ns |  92.68 ns |  1.00 |    0.00 |      - |     488 B |        1.00 |
| NullableDtoSerialize | 1000   | 129,084.1 ns | 352.18 ns | 274.96 ns |  4.84 |    0.02 | 0.4883 |   48655 B |       99.70 |
