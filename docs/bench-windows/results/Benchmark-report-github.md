```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| DtoToProto       | 1.657 μs | 0.0086 μs | 0.0067 μs | 0.1450 |    2448 B |
| ProtoSerialize   | 2.209 μs | 0.0063 μs | 0.0059 μs |      - |       7 B |
| DtoSerialize     | 4.050 μs | 0.0194 μs | 0.0182 μs | 0.1450 |    2455 B |
| ProtoDeserialize | 1.937 μs | 0.0166 μs | 0.0156 μs | 0.1945 |    3296 B |
| ProtoToDto       | 4.355 μs | 0.0144 μs | 0.0134 μs | 0.1526 |    2560 B |
| DtoDeserialize   | 6.796 μs | 0.0364 μs | 0.0323 μs | 0.3433 |    5856 B |
| JsonSerialize    | 5.053 μs | 0.0225 μs | 0.0199 μs | 0.0610 |    1088 B |
| JsonDeserialize  | 7.309 μs | 0.0341 μs | 0.0285 μs | 0.2060 |    3544 B |
