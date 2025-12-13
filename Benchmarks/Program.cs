using BenchmarkDotNet.Running;
using Benchmarks;

// Run all benchmarks
BenchmarkRunner.Run<GetModelType>();
BenchmarkRunner.Run<GetMerakiApiDomain>();
