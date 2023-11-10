``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.20348.2031), VM=Hyper-V
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.403
  [Host]     : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.457 μs | 0.0149 μs | 0.0132 μs | 0.0591 |    1512 B |
|   ProtoSerialize | 1.414 μs | 0.0019 μs | 0.0018 μs |      - |       1 B |
|     DtoSerialize | 3.073 μs | 0.0082 μs | 0.0068 μs | 0.0572 |    1513 B |
| ProtoDeserialize | 1.725 μs | 0.0029 μs | 0.0024 μs | 0.0706 |    1784 B |
|       ProtoToDto | 2.974 μs | 0.0351 μs | 0.0328 μs | 0.0534 |    1360 B |
|   DtoDeserialize | 5.066 μs | 0.0129 μs | 0.0120 μs | 0.1221 |    3144 B |
|    JsonSerialize | 3.370 μs | 0.0061 μs | 0.0057 μs | 0.0305 |     824 B |
|  JsonDeserialize | 5.935 μs | 0.0415 μs | 0.0388 μs | 0.0763 |    2016 B |
