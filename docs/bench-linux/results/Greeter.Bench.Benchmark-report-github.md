``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.403
  [Host]     : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.775 μs | 0.0332 μs | 0.0326 μs | 0.0801 |    1512 B |
|   ProtoSerialize | 1.572 μs | 0.0091 μs | 0.0085 μs |      - |       1 B |
|     DtoSerialize | 3.503 μs | 0.0040 μs | 0.0038 μs | 0.0801 |    1513 B |
| ProtoDeserialize | 2.045 μs | 0.0060 μs | 0.0056 μs | 0.0954 |    1784 B |
|       ProtoToDto | 3.349 μs | 0.0050 μs | 0.0042 μs | 0.0725 |    1360 B |
|   DtoDeserialize | 5.622 μs | 0.0175 μs | 0.0163 μs | 0.1678 |    3144 B |
|    JsonSerialize | 3.423 μs | 0.0162 μs | 0.0152 μs | 0.0420 |     824 B |
|  JsonDeserialize | 6.098 μs | 0.0223 μs | 0.0208 μs | 0.1068 |    2016 B |
