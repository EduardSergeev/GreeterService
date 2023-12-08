```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method               | Size | Mean        | Error    | StdDev   | Ratio | Gen0   | Allocated | Alloc Ratio |
|--------------------- |----- |------------:|---------:|---------:|------:|-------:|----------:|------------:|
| **&#39;string[] → byte[]&#39;**  | **1**    |    **213.8 ns** |  **0.67 ns** |  **0.60 ns** |  **0.85** | **0.0024** |     **208 B** |        **0.43** |
| &#39;string?[] → byte[]&#39; | 1    |    228.8 ns |  1.16 ns |  1.08 ns |  0.90 | 0.0029 |     240 B |        0.49 |
| &#39;string?[] → JSON&#39;   | 1    |    252.8 ns |  0.81 ns |  0.72 ns |  1.00 | 0.0057 |     488 B |        1.00 |
|                      |      |             |          |          |       |        |           |             |
| **&#39;string[] → byte[]&#39;**  | **10**   |    **555.1 ns** |  **1.31 ns** |  **1.09 ns** |  **0.72** | **0.0038** |     **360 B** |        **0.74** |
| &#39;string?[] → byte[]&#39; | 10   |  1,383.4 ns |  6.15 ns |  5.45 ns |  1.80 | 0.0076 |     680 B |        1.39 |
| &#39;string?[] → JSON&#39;   | 10   |    769.2 ns |  3.30 ns |  3.09 ns |  1.00 | 0.0057 |     488 B |        1.00 |
|                      |      |             |          |          |       |        |           |             |
| **&#39;string[] → byte[]&#39;**  | **100**  |  **5,434.9 ns** | **15.60 ns** | **14.59 ns** |  **0.52** | **0.0229** |    **2336 B** |        **4.79** |
| &#39;string?[] → byte[]&#39; | 100  | 15,121.1 ns | 37.13 ns | 34.73 ns |  1.44 | 0.0610 |    5536 B |       11.34 |
| &#39;string?[] → JSON&#39;   | 100  | 10,519.7 ns | 29.98 ns | 28.04 ns |  1.00 |      - |     488 B |        1.00 |