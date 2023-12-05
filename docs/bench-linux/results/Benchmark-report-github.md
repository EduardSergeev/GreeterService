```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| DtoToProto       | 1.930 μs | 0.0090 μs | 0.0075 μs | 0.0267 |    2448 B |
| ProtoSerialize   | 2.364 μs | 0.0147 μs | 0.0138 μs |      - |       7 B |
| DtoSerialize     | 4.585 μs | 0.0361 μs | 0.0320 μs | 0.0229 |    2455 B |
| ProtoDeserialize | 2.330 μs | 0.0139 μs | 0.0130 μs | 0.0381 |    3296 B |
| ProtoToDto       | 4.402 μs | 0.0247 μs | 0.0207 μs | 0.0305 |    2560 B |
| DtoDeserialize   | 7.365 μs | 0.0311 μs | 0.0260 μs | 0.0687 |    5856 B |
| JsonSerialize    | 5.080 μs | 0.0241 μs | 0.0201 μs | 0.0076 |    1088 B |
| JsonDeserialize  | 7.325 μs | 0.0476 μs | 0.0445 μs | 0.0381 |    3544 B |
