``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.20348.1850), VM=Hyper-V
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|           Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
|       DtoToProto | 1.680 μs | 0.0111 μs | 0.0104 μs | 0.0858 |    1608 B |
|   ProtoSerialize | 2.121 μs | 0.0172 μs | 0.0152 μs |      - |       1 B |
|     DtoSerialize | 4.003 μs | 0.0118 μs | 0.0105 μs | 0.0839 |    1609 B |
| ProtoDeserialize | 2.101 μs | 0.0074 μs | 0.0066 μs | 0.0992 |    1880 B |
|       ProtoToDto | 3.323 μs | 0.0089 μs | 0.0084 μs | 0.0916 |    1760 B |
|   DtoDeserialize | 5.826 μs | 0.0230 μs | 0.0215 μs | 0.1907 |    3640 B |
|    JsonSerialize | 3.271 μs | 0.0123 μs | 0.0109 μs | 0.0420 |     824 B |
|  JsonDeserialize | 5.937 μs | 0.0281 μs | 0.0262 μs | 0.1068 |    2016 B |
