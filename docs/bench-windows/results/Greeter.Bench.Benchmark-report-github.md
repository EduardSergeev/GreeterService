``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.20348.2031), VM=Hyper-V
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.403
  [Host]     : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.044 μs | 0.0051 μs | 0.0048 μs | 0.0896 |    1512 B |
|   ProtoSerialize | 1.039 μs | 0.0013 μs | 0.0011 μs |      - |       1 B |
|     DtoSerialize | 2.241 μs | 0.0104 μs | 0.0092 μs | 0.0877 |    1513 B |
| ProtoDeserialize | 1.260 μs | 0.0073 μs | 0.0069 μs | 0.1049 |    1784 B |
|       ProtoToDto | 2.192 μs | 0.0109 μs | 0.0102 μs | 0.0801 |    1360 B |
|   DtoDeserialize | 3.792 μs | 0.0293 μs | 0.0260 μs | 0.1869 |    3144 B |
|    JsonSerialize | 2.287 μs | 0.0070 μs | 0.0062 μs | 0.0458 |     824 B |
|  JsonDeserialize | 4.142 μs | 0.0134 μs | 0.0119 μs | 0.1144 |    2016 B |
