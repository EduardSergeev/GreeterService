``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.237 μs | 0.0079 μs | 0.0074 μs | 0.0172 |    1512 B |
|   ProtoSerialize | 1.098 μs | 0.0039 μs | 0.0033 μs |      - |       1 B |
|     DtoSerialize | 2.586 μs | 0.0182 μs | 0.0161 μs | 0.0153 |    1513 B |
| ProtoDeserialize | 1.292 μs | 0.0074 μs | 0.0069 μs | 0.0210 |    1784 B |
|       ProtoToDto | 2.626 μs | 0.0152 μs | 0.0127 μs | 0.0153 |    1360 B |
|   DtoDeserialize | 4.119 μs | 0.0081 μs | 0.0063 μs | 0.0305 |    3144 B |
|    JsonSerialize | 2.320 μs | 0.0138 μs | 0.0129 μs | 0.0076 |     824 B |
|  JsonDeserialize | 4.112 μs | 0.0146 μs | 0.0129 μs | 0.0229 |    2016 B |
