``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.20348.1850), VM=Hyper-V
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.719 μs | 0.0167 μs | 0.0156 μs | 0.0858 |    1608 B |
|   ProtoSerialize | 2.081 μs | 0.0094 μs | 0.0088 μs |      - |       1 B |
|     DtoSerialize | 4.050 μs | 0.0164 μs | 0.0153 μs | 0.0839 |    1609 B |
| ProtoDeserialize | 2.060 μs | 0.0223 μs | 0.0198 μs | 0.0992 |    1880 B |
|       ProtoToDto | 3.395 μs | 0.0090 μs | 0.0079 μs | 0.0916 |    1760 B |
|   DtoDeserialize | 5.812 μs | 0.0435 μs | 0.0407 μs | 0.1907 |    3640 B |
|    JsonSerialize | 3.292 μs | 0.0036 μs | 0.0034 μs | 0.0420 |     824 B |
|  JsonDeserialize | 5.905 μs | 0.0164 μs | 0.0145 μs | 0.1068 |    2016 B |
