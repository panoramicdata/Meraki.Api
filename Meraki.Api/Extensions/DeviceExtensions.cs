namespace Meraki.Api.Extensions;

public static class DeviceExtensions
{
	public static ModelType GetModelType(this Device device)
		=> device.Model is null || device.Model.Length < 2
				? ModelType.Unknown
				: device.Model.Substring(0, 2).ToUpperInvariant() switch
				{
					"MR" or "CW" => ModelType.WirelessLan,
					"MS" => ModelType.Switch,
					"SM" => ModelType.MobileDeviceManagement,
					"MG" => ModelType.Cellular,
					"MX" => ModelType.Appliance,
					"MV" => ModelType.Camera,
					"MT" => ModelType.Sensor,
					// If we have at least 5 characters then we can check for somee specific model types
					_ => device.Model.Length >= 5
						? device.Model.Substring(0, 5).ToUpperInvariant() switch
						{
							"C9200" or "C9300" or "C9500" => ModelType.Switch,
							_ => ModelType.Unknown
						}
						: ModelType.Unknown
				};
}
