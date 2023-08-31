namespace Meraki.Api.Extensions;

public static class DeviceExtensions
{
	public static ModelType GetModelType(this Device device)
		=> device.Model is null || device.Model.Length < 2
				? ModelType.Unknown
				: device.Model.Substring(0, 2).ToUpperInvariant() switch
				{
					"MR" => ModelType.WirelessLan,
					"MS" => ModelType.Switch,
					"SM" => ModelType.MobileDeviceManagement,
					"MG" => ModelType.Cellular,
					"MX" => ModelType.Appliance,
					"MV" => ModelType.Camera,
					"MT" => ModelType.Sensor,
					_ => device.Model.Substring(0, 5).ToUpperInvariant() switch
					{
						"C9200" or "C9300" => ModelType.Switch,
						_ => ModelType.Unknown
					}
				};
}
