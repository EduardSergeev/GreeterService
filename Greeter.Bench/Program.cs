using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Greeter.Bench;

BenchmarkRunner.Run<Benchmark>(ManualConfig
    .Create(DefaultConfig.Instance.WithArtifactsPath(Path.Combine("..", ".bench")))
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
);
