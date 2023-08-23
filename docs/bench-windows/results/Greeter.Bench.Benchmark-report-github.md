``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.20348.1850), VM=Hyper-V
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.648 μs | 0.0101 μs | 0.0094 μs | 0.0858 |    1608 B |
|   ProtoSerialize | 2.080 μs | 0.0081 μs | 0.0076 μs |      - |       1 B |
|     DtoSerialize | 4.021 μs | 0.0116 μs | 0.0108 μs | 0.0839 |    1609 B |
| ProtoDeserialize | 2.020 μs | 0.0099 μs | 0.0093 μs | 0.0992 |    1880 B |
|       ProtoToDto | 3.293 μs | 0.0096 μs | 0.0085 μs | 0.0916 |    1760 B |
|   DtoDeserialize | 5.647 μs | 0.0157 μs | 0.0131 μs | 0.1907 |    3640 B |
|    JsonSerialize | 3.310 μs | 0.0046 μs | 0.0043 μs | 0.0420 |     824 B |
|  JsonDeserialize | 5.860 μs | 0.0159 μs | 0.0149 μs | 0.1068 |    2016 B |
