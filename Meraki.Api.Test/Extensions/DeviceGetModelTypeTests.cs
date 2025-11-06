namespace Meraki.Api.Test.Extensions;

public class DeviceGetModelTypeTests
{
	[Theory]
	[InlineData("MR1234", ModelType.WirelessLan)]
	[InlineData("MS1234", ModelType.Switch)]
	[InlineData("SM1234", ModelType.MobileDeviceManagement)]
	[InlineData("MG1234", ModelType.Cellular)]
	[InlineData("MX1234", ModelType.Appliance)]
	[InlineData("MV1234", ModelType.Camera)]
	[InlineData("MT1234", ModelType.Sensor)]
	[InlineData("XY1234", ModelType.Unknown)]
	[InlineData("mr1234", ModelType.WirelessLan)]
	[InlineData("ms1234", ModelType.Switch)]
	[InlineData("sm1234", ModelType.MobileDeviceManagement)]
	[InlineData("mg1234", ModelType.Cellular)]
	[InlineData("mx1234", ModelType.Appliance)]
	[InlineData("mv1234", ModelType.Camera)]
	[InlineData("mt1234", ModelType.Sensor)]
	[InlineData("xy1234", ModelType.Unknown)]
	[InlineData("xy123", ModelType.Unknown)]
	[InlineData("z3", ModelType.Appliance)]
	[InlineData("Z3", ModelType.Appliance)]
	[InlineData("z4", ModelType.Appliance)]
	[InlineData("Z4", ModelType.Appliance)]
	[InlineData("Z3C", ModelType.Appliance)]
	[InlineData("Z3C-WW", ModelType.Appliance)]
	[InlineData("VMX", ModelType.Appliance)]
	[InlineData("VMX-S", ModelType.Appliance)]
	[InlineData("VMX-M", ModelType.Appliance)]
	[InlineData("vMX100", ModelType.Appliance)]
	[InlineData("UMB-SIG", ModelType.Appliance)]
	[InlineData("X", ModelType.Unknown)]
	[InlineData("XX", ModelType.Unknown)]
	[InlineData("XXX", ModelType.Unknown)]
	[InlineData("XXXX", ModelType.Unknown)]
	[InlineData("XXXXX", ModelType.Unknown)]
	[InlineData("XXXXXX", ModelType.Unknown)]
	[InlineData("CPSC-HUB", ModelType.CiscoSecureConnect)]
	public void DeviceGetModelType_ReturnsExpectedType(string model, ModelType expected)
	{
		var device = new Device { Model = model };
		var actual = device!.GetModelType();
		_ = actual.Should().Be(expected);
	}
}
