``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.20348.2113), VM=Hyper-V
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.024 μs | 0.0044 μs | 0.0041 μs | 0.0896 |    1512 B |
|   ProtoSerialize | 1.023 μs | 0.0064 μs | 0.0057 μs |      - |       1 B |
|     DtoSerialize | 2.212 μs | 0.0195 μs | 0.0182 μs | 0.0877 |    1513 B |
| ProtoDeserialize | 1.172 μs | 0.0082 μs | 0.0077 μs | 0.1049 |    1784 B |
|       ProtoToDto | 2.138 μs | 0.0104 μs | 0.0097 μs | 0.0801 |    1360 B |
|   DtoDeserialize | 3.660 μs | 0.0327 μs | 0.0306 μs | 0.1869 |    3144 B |
|    JsonSerialize | 2.228 μs | 0.0125 μs | 0.0117 μs | 0.0458 |     824 B |
|  JsonDeserialize | 4.038 μs | 0.0281 μs | 0.0250 μs | 0.1144 |    2016 B |
