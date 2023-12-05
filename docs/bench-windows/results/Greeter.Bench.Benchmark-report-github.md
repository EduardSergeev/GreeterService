```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.20348.2113) (Hyper-V)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| DtoToProto       | 1.704 μs | 0.0065 μs | 0.0061 μs | 0.1450 |    2448 B |
| ProtoSerialize   | 2.180 μs | 0.0112 μs | 0.0105 μs |      - |       7 B |
| DtoSerialize     | 4.052 μs | 0.0064 μs | 0.0053 μs | 0.1450 |    2455 B |
| ProtoDeserialize | 2.012 μs | 0.0069 μs | 0.0058 μs | 0.1945 |    3296 B |
| ProtoToDto       | 4.397 μs | 0.0091 μs | 0.0086 μs | 0.1526 |    2560 B |
| DtoDeserialize   | 6.826 μs | 0.0143 μs | 0.0134 μs | 0.3433 |    5856 B |
| JsonSerialize    | 4.987 μs | 0.0147 μs | 0.0130 μs | 0.0610 |    1088 B |
| JsonDeserialize  | 7.591 μs | 0.0169 μs | 0.0149 μs | 0.2060 |    3544 B |
