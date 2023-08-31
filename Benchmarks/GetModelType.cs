using BenchmarkDotNet.Attributes;
using Meraki.Api.Data;
using Meraki.Api.Extensions;

namespace Benchmarks;
[MemoryDiagnoser]
public class GetModelType
{
	private readonly Device _device;

	public GetModelType()
	{
		_device = new Device { Model = "MR1234" };
	}

	[Benchmark]
	public ModelType DeviceGetModelType()
		=> _device.GetModelType();

}
