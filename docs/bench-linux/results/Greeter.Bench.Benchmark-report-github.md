``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.693 μs | 0.0098 μs | 0.0082 μs | 0.0629 |    1608 B |
|   ProtoSerialize | 1.957 μs | 0.0016 μs | 0.0015 μs |      - |       1 B |
|     DtoSerialize | 4.047 μs | 0.0137 μs | 0.0128 μs | 0.0610 |    1609 B |
| ProtoDeserialize | 2.199 μs | 0.0417 μs | 0.0390 μs | 0.0725 |    1880 B |
|       ProtoToDto | 3.310 μs | 0.0098 μs | 0.0087 μs | 0.0687 |    1760 B |
|   DtoDeserialize | 5.892 μs | 0.0274 μs | 0.0257 μs | 0.1450 |    3640 B |
|    JsonSerialize | 3.458 μs | 0.0063 μs | 0.0059 μs | 0.0305 |     824 B |
|  JsonDeserialize | 6.054 μs | 0.0394 μs | 0.0368 μs | 0.0763 |    2016 B |
