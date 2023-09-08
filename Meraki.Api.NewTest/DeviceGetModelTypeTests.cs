using Meraki.Api.Data;
using Meraki.Api.Extensions;

namespace Meraki.Api.NewTest;
public class DeviceGetModelTypeTests
{
	[Theory]
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant
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
#pragma warning restore CS3016 // Arrays as attribute arguments is not CLS-compliant
	public void DeviceGetModelType_ReturnsExpectedType(string model, ModelType expected)
	{
		var device = new Device { Model = model };
		var actual = device!.GetModelType();
		Assert.Equal(expected, actual);
	}
}
