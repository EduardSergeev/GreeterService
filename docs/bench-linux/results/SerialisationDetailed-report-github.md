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
| **DtoToProto**     | **1**    |    **905.9 ns** |   **2.58 ns** |   **2.29 ns** |  **0.61** | **0.0153** |    **1320 B** |       **0.998** |
| ProtoSerialize | 1    |    471.3 ns |   1.37 ns |   1.22 ns |  0.32 |      - |       2 B |       0.002 |
| DtoSerialize   | 1    |  1,484.6 ns |   4.52 ns |   4.01 ns |  1.00 | 0.0153 |    1322 B |       1.000 |
|                |      |             |           |           |       |        |           |             |
| **DtoToProto**     | **10**   |  **3,781.5 ns** |  **15.81 ns** |  **14.79 ns** |  **0.38** | **0.0572** |    **5072 B** |       **0.997** |
| ProtoSerialize | 10   |  5,390.1 ns |  20.25 ns |  17.96 ns |  0.54 |      - |      15 B |       0.003 |
| DtoSerialize   | 10   |  9,949.4 ns |  55.61 ns |  52.02 ns |  1.00 | 0.0458 |    5087 B |       1.000 |
|                |      |             |           |           |       |        |           |             |
| **DtoToProto**     | **100**  | **31,546.6 ns** | **167.24 ns** | **156.44 ns** |  **0.37** | **0.4883** |   **42920 B** |       **0.996** |
| ProtoSerialize | 100  | 53,936.4 ns | 218.86 ns | 182.76 ns |  0.64 |      - |     151 B |       0.004 |
| DtoSerialize   | 100  | 84,876.5 ns | 221.15 ns | 206.86 ns |  1.00 | 0.4883 |   43071 B |       1.000 |
