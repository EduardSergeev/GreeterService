```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]                : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  SerialisationDetailed : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=SerialisationDetailed  

```
| Method         | Size | Mean        | Error     | StdDev    | Ratio | Gen0   | Gen1   | Allocated | Alloc Ratio |
|--------------- |----- |------------:|----------:|----------:|------:|-------:|-------:|----------:|------------:|
| **DtoToProto**     | **1**    |    **780.7 ns** |   **9.41 ns** |   **8.80 ns** |  **0.53** | **0.0782** |      **-** |    **1320 B** |       **0.998** |
| ProtoSerialize | 1    |    420.2 ns |   1.86 ns |   1.74 ns |  0.29 |      - |      - |       2 B |       0.002 |
| DtoSerialize   | 1    |  1,470.8 ns |   3.13 ns |   2.93 ns |  1.00 | 0.0782 |      - |    1322 B |       1.000 |
|                |      |             |           |           |       |        |        |           |             |
| **DtoToProto**     | **10**   |  **3,503.1 ns** |  **10.56 ns** |   **9.88 ns** |  **0.39** | **0.3014** | **0.0038** |    **5072 B** |       **0.997** |
| ProtoSerialize | 10   |  5,036.9 ns |  22.02 ns |  19.52 ns |  0.56 |      - |      - |      15 B |       0.003 |
| DtoSerialize   | 10   |  8,935.0 ns |  21.42 ns |  20.04 ns |  1.00 | 0.2899 |      - |    5087 B |       1.000 |
|                |      |             |           |           |       |        |        |           |             |
| **DtoToProto**     | **100**  | **29,012.4 ns** | **534.97 ns** | **500.41 ns** |  **0.36** | **2.5635** | **0.2441** |   **42920 B** |       **0.996** |
| ProtoSerialize | 100  | 50,351.0 ns |  38.30 ns |  33.95 ns |  0.62 |      - |      - |     151 B |       0.004 |
| DtoSerialize   | 100  | 81,137.1 ns | 403.26 ns | 377.21 ns |  1.00 | 2.5635 | 0.2441 |   43071 B |       1.000 |
