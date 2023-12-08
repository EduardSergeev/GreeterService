```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method               | Size | Mean        | Error    | StdDev   | Ratio | Gen0   | Allocated | Alloc Ratio |
|--------------------- |----- |------------:|---------:|---------:|------:|-------:|----------:|------------:|
| **&#39;string[] → byte[]&#39;**  | **1**    |    **183.9 ns** |  **1.47 ns** |  **1.38 ns** |  **0.86** | **0.0124** |     **208 B** |        **0.43** |
| &#39;string?[] → byte[]&#39; | 1    |    196.1 ns |  1.12 ns |  1.05 ns |  0.92 | 0.0143 |     240 B |        0.49 |
| &#39;string?[] → JSON&#39;   | 1    |    212.8 ns |  2.36 ns |  2.21 ns |  1.00 | 0.0291 |     488 B |        1.00 |
|                      |      |             |          |          |       |        |           |             |
| **&#39;string[] → byte[]&#39;**  | **10**   |    **523.4 ns** |  **0.84 ns** |  **0.78 ns** |  **0.62** | **0.0210** |     **360 B** |        **0.74** |
| &#39;string?[] → byte[]&#39; | 10   |  1,289.5 ns |  4.58 ns |  4.28 ns |  1.52 | 0.0401 |     680 B |        1.39 |
| &#39;string?[] → JSON&#39;   | 10   |    849.7 ns |  3.47 ns |  3.25 ns |  1.00 | 0.0286 |     488 B |        1.00 |
|                      |      |             |          |          |       |        |           |             |
| **&#39;string[] → byte[]&#39;**  | **100**  |  **5,108.1 ns** | **32.00 ns** | **28.37 ns** |  **0.42** | **0.1373** |    **2336 B** |        **4.79** |
| &#39;string?[] → byte[]&#39; | 100  | 13,890.7 ns | 35.42 ns | 33.13 ns |  1.15 | 0.3204 |    5536 B |       11.34 |
| &#39;string?[] → JSON&#39;   | 100  | 12,032.4 ns |  9.87 ns |  8.75 ns |  1.00 | 0.0153 |     488 B |        1.00 |