``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.667 μs | 0.0075 μs | 0.0066 μs | 0.0629 |    1608 B |
|   ProtoSerialize | 1.958 μs | 0.0016 μs | 0.0015 μs |      - |       1 B |
|     DtoSerialize | 4.027 μs | 0.0383 μs | 0.0358 μs | 0.0610 |    1609 B |
| ProtoDeserialize | 2.178 μs | 0.0084 μs | 0.0078 μs | 0.0725 |    1880 B |
|       ProtoToDto | 3.338 μs | 0.0031 μs | 0.0026 μs | 0.0687 |    1760 B |
|   DtoDeserialize | 5.978 μs | 0.0156 μs | 0.0146 μs | 0.1450 |    3640 B |
|    JsonSerialize | 3.356 μs | 0.0037 μs | 0.0034 μs | 0.0305 |     824 B |
|  JsonDeserialize | 6.090 μs | 0.0203 μs | 0.0190 μs | 0.0763 |    2016 B |
