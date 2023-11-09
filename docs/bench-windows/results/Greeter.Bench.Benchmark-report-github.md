``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.20348.2031), VM=Hyper-V
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.403
  [Host]     : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.585 μs | 0.0064 μs | 0.0059 μs | 0.0801 |    1512 B |
|   ProtoSerialize | 1.548 μs | 0.0079 μs | 0.0070 μs |      - |       1 B |
|     DtoSerialize | 3.486 μs | 0.0141 μs | 0.0132 μs | 0.0801 |    1513 B |
| ProtoDeserialize | 1.770 μs | 0.0087 μs | 0.0081 μs | 0.0954 |    1784 B |
|       ProtoToDto | 3.105 μs | 0.0083 μs | 0.0074 μs | 0.0725 |    1360 B |
|   DtoDeserialize | 5.160 μs | 0.0151 μs | 0.0141 μs | 0.1678 |    3144 B |
|    JsonSerialize | 3.308 μs | 0.0135 μs | 0.0126 μs | 0.0420 |     824 B |
|  JsonDeserialize | 6.041 μs | 0.0213 μs | 0.0199 μs | 0.1068 |    2016 B |
