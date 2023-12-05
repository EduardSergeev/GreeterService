```

BenchmarkDotNet v0.13.10, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| DtoToProto       | 1.834 μs | 0.0074 μs | 0.0065 μs | 0.0286 |    2448 B |
| ProtoSerialize   | 2.362 μs | 0.0089 μs | 0.0079 μs |      - |       7 B |
| DtoSerialize     | 4.552 μs | 0.0305 μs | 0.0285 μs | 0.0229 |    2455 B |
| ProtoDeserialize | 2.284 μs | 0.0077 μs | 0.0068 μs | 0.0381 |    3296 B |
| ProtoToDto       | 4.629 μs | 0.0165 μs | 0.0146 μs | 0.0305 |    2560 B |
| DtoDeserialize   | 7.382 μs | 0.0316 μs | 0.0264 μs | 0.0610 |    5856 B |
| JsonSerialize    | 5.277 μs | 0.0470 μs | 0.0440 μs | 0.0076 |    1088 B |
| JsonDeserialize  | 7.310 μs | 0.0465 μs | 0.0435 μs | 0.0381 |    3544 B |
