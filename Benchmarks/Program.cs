using BenchmarkDotNet.Running;
using Benchmarks;

if (args.Length == 0)
{
	_ = BenchmarkRunner.Run<GetModelType>();
}
else
{
	_ = BenchmarkSwitcher.FromAssembly(typeof(GetModelType).Assembly).Run(args);
}
