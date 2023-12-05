```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method               | Length | Mean         | Error     | StdDev    | Ratio | Gen0   | Gen1   | Allocated | Alloc Ratio |
|--------------------- |------- |-------------:|----------:|----------:|------:|-------:|-------:|----------:|------------:|
| **DtoSerialize**         | **10**     |     **487.1 ns** |   **0.84 ns** |   **0.74 ns** |  **1.07** | **0.0210** |      **-** |     **360 B** |        **0.74** |
| JsonSerialize        | 10     |     457.0 ns |   1.04 ns |   0.92 ns |  1.00 | 0.0291 |      - |     488 B |        1.00 |
| NullableDtoSerialize | 10     |   1,358.1 ns |   3.61 ns |   3.38 ns |  2.97 | 0.0401 |      - |     680 B |        1.39 |
|                      |        |              |           |           |       |        |        |           |             |
| **DtoSerialize**         | **100**    |   **3,494.1 ns** |   **6.94 ns** |   **6.15 ns** |  **1.39** | **0.1297** |      **-** |    **2225 B** |        **4.56** |
| JsonSerialize        | 100    |   2,519.2 ns |   3.37 ns |   3.15 ns |  1.00 | 0.0267 |      - |     488 B |        1.00 |
| NullableDtoSerialize | 100    |  11,672.3 ns |  16.40 ns |  12.80 ns |  4.63 | 0.3204 |      - |    5426 B |       11.12 |
|                      |        |              |           |           |       |        |        |           |             |
| **DtoSerialize**         | **1000**   |  **32,632.5 ns** |  **63.16 ns** |  **55.99 ns** |  **1.37** | **0.9766** |      **-** |   **16655 B** |       **34.13** |
| JsonSerialize        | 1000   |  23,785.3 ns |  37.80 ns |  33.50 ns |  1.00 |      - |      - |     488 B |        1.00 |
| NullableDtoSerialize | 1000   | 118,096.0 ns | 137.97 ns | 122.31 ns |  4.97 | 2.8076 | 0.3662 |   48655 B |       99.70 |
