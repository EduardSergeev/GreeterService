``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.403
  [Host]     : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.151 μs | 0.0032 μs | 0.0025 μs | 0.0172 |    1512 B |
|   ProtoSerialize | 1.110 μs | 0.0017 μs | 0.0015 μs |      - |       1 B |
|     DtoSerialize | 2.425 μs | 0.0049 μs | 0.0046 μs | 0.0153 |    1513 B |
| ProtoDeserialize | 1.291 μs | 0.0036 μs | 0.0030 μs | 0.0210 |    1784 B |
|       ProtoToDto | 2.641 μs | 0.0097 μs | 0.0081 μs | 0.0153 |    1360 B |
|   DtoDeserialize | 4.285 μs | 0.0119 μs | 0.0100 μs | 0.0305 |    3144 B |
|    JsonSerialize | 2.315 μs | 0.0047 μs | 0.0041 μs | 0.0076 |     824 B |
|  JsonDeserialize | 4.102 μs | 0.0124 μs | 0.0116 μs | 0.0229 |    2016 B |
