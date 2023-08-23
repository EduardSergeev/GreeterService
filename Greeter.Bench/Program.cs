using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Greeter.Bench;
using static System.Environment;

BenchmarkRunner.Run<Benchmark>(ManualConfig
    .Create(DefaultConfig.Instance.WithArtifactsPath(Path.Combine("..", ".bench", GetEnvironmentVariable("BENCH_RESULT_SUBPATH") ?? "")))
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
);
