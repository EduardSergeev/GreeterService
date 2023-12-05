```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]                : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  SerialisationDetailed : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=SerialisationDetailed  

```
| Method         | Size | Mean        | Error     | StdDev    | Ratio | Gen0   | Allocated | Alloc Ratio |
|--------------- |----- |------------:|----------:|----------:|------:|-------:|----------:|------------:|
| **DtoToProto**     | **1**    |    **887.4 ns** |   **3.13 ns** |   **2.93 ns** |  **0.59** | **0.0153** |    **1320 B** |       **0.998** |
| ProtoSerialize | 1    |    459.8 ns |   1.22 ns |   1.14 ns |  0.30 |      - |       2 B |       0.002 |
| DtoSerialize   | 1    |  1,508.7 ns |   4.78 ns |   4.24 ns |  1.00 | 0.0153 |    1322 B |       1.000 |
|                |      |             |           |           |       |        |           |             |
| **DtoToProto**     | **10**   |  **3,929.5 ns** |  **25.71 ns** |  **24.05 ns** |  **0.40** | **0.0534** |    **5072 B** |       **0.997** |
| ProtoSerialize | 10   |  5,335.5 ns |  34.25 ns |  32.03 ns |  0.55 |      - |      15 B |       0.003 |
| DtoSerialize   | 10   |  9,778.6 ns |  58.49 ns |  51.85 ns |  1.00 | 0.0458 |    5087 B |       1.000 |
|                |      |             |           |           |       |        |           |             |
| **DtoToProto**     | **100**  | **33,756.5 ns** | **130.79 ns** | **115.94 ns** |  **0.39** | **0.4883** |   **42920 B** |       **0.996** |
| ProtoSerialize | 100  | 53,990.3 ns | 162.13 ns | 151.66 ns |  0.62 |      - |     151 B |       0.004 |
| DtoSerialize   | 100  | 86,399.8 ns | 453.99 ns | 402.45 ns |  1.00 | 0.4883 |   43071 B |       1.000 |
