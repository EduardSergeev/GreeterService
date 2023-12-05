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
| **DtoToProto**     | **1**    |    **792.8 ns** |   **2.24 ns** |   **2.09 ns** |  **0.58** | **0.0782** |      **-** |    **1320 B** |       **0.998** |
| ProtoSerialize | 1    |    416.0 ns |   1.13 ns |   1.06 ns |  0.30 |      - |      - |       2 B |       0.002 |
| DtoSerialize   | 1    |  1,365.4 ns |   2.67 ns |   2.36 ns |  1.00 | 0.0782 |      - |    1322 B |       1.000 |
|                |      |             |           |           |       |        |        |           |             |
| **DtoToProto**     | **10**   |  **3,505.9 ns** |  **14.05 ns** |  **13.15 ns** |  **0.39** | **0.3014** | **0.0038** |    **5072 B** |       **0.997** |
| ProtoSerialize | 10   |  5,118.3 ns |  21.37 ns |  19.99 ns |  0.57 |      - |      - |      15 B |       0.003 |
| DtoSerialize   | 10   |  8,982.6 ns |  28.24 ns |  25.04 ns |  1.00 | 0.2899 |      - |    5087 B |       1.000 |
|                |      |             |           |           |       |        |        |           |             |
| **DtoToProto**     | **100**  | **29,543.6 ns** |  **95.22 ns** |  **84.41 ns** |  **0.35** | **2.5635** | **0.2441** |   **42920 B** |       **0.996** |
| ProtoSerialize | 100  | 49,470.9 ns | 359.77 ns | 336.53 ns |  0.59 |      - |      - |     151 B |       0.004 |
| DtoSerialize   | 100  | 83,658.9 ns | 360.93 ns | 337.61 ns |  1.00 | 2.5635 | 0.2441 |   43071 B |       1.000 |
