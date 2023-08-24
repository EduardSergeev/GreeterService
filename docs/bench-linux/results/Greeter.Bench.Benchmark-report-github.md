``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.600 μs | 0.0071 μs | 0.0063 μs | 0.0629 |    1608 B |
|   ProtoSerialize | 1.962 μs | 0.0019 μs | 0.0017 μs |      - |       1 B |
|     DtoSerialize | 3.880 μs | 0.0086 μs | 0.0076 μs | 0.0610 |    1609 B |
| ProtoDeserialize | 2.104 μs | 0.0102 μs | 0.0095 μs | 0.0725 |    1880 B |
|       ProtoToDto | 3.253 μs | 0.0095 μs | 0.0089 μs | 0.0687 |    1760 B |
|   DtoDeserialize | 5.922 μs | 0.0195 μs | 0.0183 μs | 0.1450 |    3640 B |
|    JsonSerialize | 3.297 μs | 0.0046 μs | 0.0041 μs | 0.0305 |     824 B |
|  JsonDeserialize | 6.014 μs | 0.0200 μs | 0.0187 μs | 0.0763 |    2016 B |
