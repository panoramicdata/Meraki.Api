namespace Meraki.Api.Extensions;

public static class DeviceExtensions
{
	public static ModelType GetModelType(this Device device)
	{
		var deviceModelUpper = device.Model?.ToUpperInvariant();

		return deviceModelUpper == "UMB-SIG"
				? ModelType.Appliance
				: deviceModelUpper?.Length >= 2
					? deviceModelUpper.Substring(0, 2) switch
					{
						// Try matching on the first two characters
						"MR" or "CW" => ModelType.WirelessLan,
						"MS" => ModelType.Switch,
						"SM" => ModelType.MobileDeviceManagement,
						"MG" => ModelType.Cellular,
						"MX" or "Z3" or "Z4"=> ModelType.Appliance,
						"MV" => ModelType.Camera,
						"MT" => ModelType.Sensor,
						// We didn't manage to match on the first two characters
						_ => deviceModelUpper?.Length >= 3
							? deviceModelUpper.Substring(0, 3) switch
							{
								"VMX" => ModelType.Appliance,
								// We didn't manage to match on the first three characters
								_ => deviceModelUpper.Length >= 5
									? deviceModelUpper.Substring(0, 5) switch
									{
										"C9200" or "C9300" or "C9500" => ModelType.Switch,
										// We don't know what this is
										_ => ModelType.Unknown
									}
									: ModelType.Unknown
							}
							: ModelType.Unknown
					}
					: ModelType.Unknown;
	}
}
