```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method               | Size | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|--------------------- |----- |------------:|----------:|----------:|------:|--------:|-------:|-------:|----------:|------------:|
| **&#39;byte[] → string[]&#39;**  | **1**    |    **259.7 ns** |   **4.02 ns** |   **3.76 ns** |  **0.88** |    **0.02** | **0.0248** |      **-** |     **416 B** |        **0.71** |
| &#39;byte[] → string?[]&#39; | 1    |    290.6 ns |   2.03 ns |   1.70 ns |  0.99 |    0.01 | 0.0315 |      - |     528 B |        0.90 |
| &#39;JSON → string?[]&#39;   | 1    |    293.9 ns |   3.83 ns |   3.58 ns |  1.00 |    0.00 | 0.0348 |      - |     584 B |        1.00 |
|                      |      |             |           |           |       |         |        |        |           |             |
| **&#39;byte[] → string[]&#39;**  | **10**   |    **520.7 ns** |   **6.71 ns** |   **5.95 ns** |  **0.48** |    **0.01** | **0.0610** |      **-** |    **1024 B** |        **0.88** |
| &#39;byte[] → string?[]&#39; | 10   |  1,279.0 ns |   5.96 ns |   5.57 ns |  1.19 |    0.01 | 0.0820 |      - |    1384 B |        1.18 |
| &#39;JSON → string?[]&#39;   | 10   |  1,079.1 ns |  11.10 ns |  10.38 ns |  1.00 |    0.00 | 0.0687 |      - |    1168 B |        1.00 |
|                      |      |             |           |           |       |         |        |        |           |             |
| **&#39;byte[] → string[]&#39;**  | **100**  |  **4,424.0 ns** |  **85.91 ns** |  **84.37 ns** |  **0.25** |    **0.00** | **0.9766** | **0.0229** |   **16392 B** |        **1.05** |
| &#39;byte[] → string?[]&#39; | 100  | 11,280.6 ns | 184.33 ns | 172.43 ns |  0.63 |    0.01 | 1.1597 | 0.0610 |   19448 B |        1.24 |
| &#39;JSON → string?[]&#39;   | 100  | 17,950.6 ns |  84.37 ns |  74.79 ns |  1.00 |    0.00 | 0.9155 |      - |   15632 B |        1.00 |