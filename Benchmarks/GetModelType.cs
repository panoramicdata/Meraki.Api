using BenchmarkDotNet.Attributes;
using Meraki.Api.Data;
using Meraki.Api.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Benchmarks;

/// <summary>
/// Benchmarks for GetModelType extension method
/// </summary>
[MemoryDiagnoser]
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Benchmark method names for clarity")]
public class GetModelType
{
	private readonly Device _deviceMR;
	private readonly Device _deviceMS;
	private readonly Device _deviceMX;
	private readonly Device _deviceMV;
	private readonly Device _deviceMT;
	private readonly Device _deviceCPSC;
	private readonly Device _deviceVMX;
	private readonly Device _deviceC9300;
	private readonly Device _deviceUnknown;

	public GetModelType()
	{
		_deviceMR = new Device { Model = "MR1234" };
		_deviceMS = new Device { Model = "MS250-48" };
		_deviceMX = new Device { Model = "MX67C" };
		_deviceMV = new Device { Model = "MV12" };
		_deviceMT = new Device { Model = "MT10" };
		_deviceCPSC = new Device { Model = "CPSC-HUB" };
		_deviceVMX = new Device { Model = "VMX-L" };
		_deviceC9300 = new Device { Model = "C9300-48" };
		_deviceUnknown = new Device { Model = "UNKNOWN" };
	}

	[Benchmark]
	public ModelType DeviceGetModelType_MR()
		=> _deviceMR.GetModelType();

	[Benchmark]
	public ModelType DeviceGetModelType_MS()
		=> _deviceMS.GetModelType();

	[Benchmark]
	public ModelType DeviceGetModelType_MX()
		=> _deviceMX.GetModelType();

	[Benchmark]
	public ModelType DeviceGetModelType_MV()
		=> _deviceMV.GetModelType();

	[Benchmark]
	public ModelType DeviceGetModelType_MT()
		=> _deviceMT.GetModelType();

	[Benchmark]
	public ModelType DeviceGetModelType_CPSC()
		=> _deviceCPSC.GetModelType();

	[Benchmark]
	public ModelType DeviceGetModelType_VMX()
		=> _deviceVMX.GetModelType();

	[Benchmark]
	public ModelType DeviceGetModelType_C9300()
		=> _deviceC9300.GetModelType();

	[Benchmark]
	public ModelType DeviceGetModelType_Unknown()
		=> _deviceUnknown.GetModelType();
}
