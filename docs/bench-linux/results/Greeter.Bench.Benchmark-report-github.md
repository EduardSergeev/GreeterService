``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.403
  [Host]     : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.168 μs | 0.0051 μs | 0.0045 μs | 0.0172 |    1512 B |
|   ProtoSerialize | 1.115 μs | 0.0070 μs | 0.0066 μs |      - |       1 B |
|     DtoSerialize | 2.440 μs | 0.0081 μs | 0.0068 μs | 0.0153 |    1513 B |
| ProtoDeserialize | 1.279 μs | 0.0111 μs | 0.0104 μs | 0.0210 |    1784 B |
|       ProtoToDto | 2.680 μs | 0.0153 μs | 0.0128 μs | 0.0153 |    1360 B |
|   DtoDeserialize | 4.278 μs | 0.0245 μs | 0.0229 μs | 0.0305 |    3144 B |
|    JsonSerialize | 2.341 μs | 0.0157 μs | 0.0147 μs | 0.0076 |     824 B |
|  JsonDeserialize | 4.167 μs | 0.0283 μs | 0.0264 μs | 0.0229 |    2016 B |
