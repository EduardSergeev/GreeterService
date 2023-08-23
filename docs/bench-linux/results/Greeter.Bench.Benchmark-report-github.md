``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 2.120 μs | 0.0293 μs | 0.0274 μs | 0.0839 |    1608 B |
|   ProtoSerialize | 2.468 μs | 0.0270 μs | 0.0211 μs |      - |       1 B |
|     DtoSerialize | 4.939 μs | 0.0273 μs | 0.0242 μs | 0.0839 |    1609 B |
| ProtoDeserialize | 2.700 μs | 0.0281 μs | 0.0262 μs | 0.0992 |    1880 B |
|       ProtoToDto | 4.126 μs | 0.0432 μs | 0.0404 μs | 0.0916 |    1760 B |
|   DtoDeserialize | 7.312 μs | 0.0610 μs | 0.0571 μs | 0.1907 |    3640 B |
|    JsonSerialize | 3.911 μs | 0.0257 μs | 0.0240 μs | 0.0381 |     824 B |
|  JsonDeserialize | 7.160 μs | 0.0752 μs | 0.0703 μs | 0.1068 |    2016 B |
