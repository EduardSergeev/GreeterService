``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.20348.1850), VM=Hyper-V
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.590 μs | 0.0118 μs | 0.0111 μs | 0.0858 |    1608 B |
|   ProtoSerialize | 1.869 μs | 0.0088 μs | 0.0082 μs |      - |       1 B |
|     DtoSerialize | 3.599 μs | 0.0257 μs | 0.0240 μs | 0.0839 |    1609 B |
| ProtoDeserialize | 1.854 μs | 0.0080 μs | 0.0075 μs | 0.0992 |    1880 B |
|       ProtoToDto | 3.099 μs | 0.0200 μs | 0.0187 μs | 0.0916 |    1760 B |
|   DtoDeserialize | 5.343 μs | 0.0393 μs | 0.0368 μs | 0.1907 |    3640 B |
|    JsonSerialize | 3.028 μs | 0.0123 μs | 0.0115 μs | 0.0420 |     824 B |
|  JsonDeserialize | 5.412 μs | 0.0417 μs | 0.0390 μs | 0.1068 |    2016 B |
