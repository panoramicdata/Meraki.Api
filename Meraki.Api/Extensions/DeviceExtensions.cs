namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for Device
/// </summary>
public static class DeviceExtensions
{
	/// <summary>
	/// Gets the model type for a device based on its model string
	/// </summary>
	/// <param name="device">The device</param>
	/// <returns>The model type category</returns>
	public static ModelType GetModelType(this Device device)
	{
		// Optimized: Use ReadOnlySpan to avoid string allocations
		var deviceModel = device.Model;
		if (string.IsNullOrEmpty(deviceModel))
		{
			return ModelType.Unknown;
		}

#if NETSTANDARD2_0
		// For .NET Standard 2.0, we need to create the uppercased string once
		// At this point, deviceModel is not null due to the check above
		var deviceModelUpper = deviceModel!.ToUpperInvariant();
		
		// Check exact matches first (most specific)
		if (deviceModelUpper == "CPSC-HUB")
		{
			return ModelType.CiscoSecureConnect;
		}

		if (deviceModelUpper == "UMB-SIG")
		{
			return ModelType.Appliance;
		}

		// Check by length and prefix
		var length = deviceModelUpper.Length;
		if (length >= 2)
		{
			var prefix2 = deviceModelUpper.Substring(0, 2);
			switch (prefix2)
			{
				case "MR":
				case "CW":
					return ModelType.WirelessLan;
				case "MS":
					return ModelType.Switch;
				case "SM":
					return ModelType.MobileDeviceManagement;
				case "MG":
					return ModelType.Cellular;
				case "MX":
				case "Z3":
				case "Z4":
					return ModelType.Appliance;
				case "MV":
					return ModelType.Camera;
				case "MT":
					return ModelType.Sensor;
			}

			if (length >= 3)
			{
				var prefix3 = deviceModelUpper.Substring(0, 3);
				if (prefix3 == "VMX")
				{
					return ModelType.Appliance;
				}

				if (length >= 5)
				{
					var prefix5 = deviceModelUpper.Substring(0, 5);
					switch (prefix5)
					{
						case "C9200":
						case "C9300":
						case "C9500":
							return ModelType.Switch;
					}
				}
			}
		}
#else
		// For modern .NET, use ReadOnlySpan to avoid allocations
		var span = deviceModel.AsSpan();
		
		// Check exact matches first (most specific)
		if (span.Equals("CPSC-HUB", StringComparison.OrdinalIgnoreCase))
		{
			return ModelType.CiscoSecureConnect;
		}

		if (span.Equals("UMB-SIG", StringComparison.OrdinalIgnoreCase))
		{
			return ModelType.Appliance;
		}

		// Check by length and prefix
		var length = span.Length;
		if (length >= 2)
		{
			var prefix2 = span[..2];
			if (prefix2.Equals("MR", StringComparison.OrdinalIgnoreCase) ||
				prefix2.Equals("CW", StringComparison.OrdinalIgnoreCase))
			{
				return ModelType.WirelessLan;
			}

			if (prefix2.Equals("MS", StringComparison.OrdinalIgnoreCase))
			{
				return ModelType.Switch;
			}

			if (prefix2.Equals("SM", StringComparison.OrdinalIgnoreCase))
			{
				return ModelType.MobileDeviceManagement;
			}

			if (prefix2.Equals("MG", StringComparison.OrdinalIgnoreCase))
			{
				return ModelType.Cellular;
			}

			if (prefix2.Equals("MX", StringComparison.OrdinalIgnoreCase) ||
				prefix2.Equals("Z3", StringComparison.OrdinalIgnoreCase) ||
				prefix2.Equals("Z4", StringComparison.OrdinalIgnoreCase))
			{
				return ModelType.Appliance;
			}

			if (prefix2.Equals("MV", StringComparison.OrdinalIgnoreCase))
			{
				return ModelType.Camera;
			}

			if (prefix2.Equals("MT", StringComparison.OrdinalIgnoreCase))
			{
				return ModelType.Sensor;
			}

			if (length >= 3)
			{
				var prefix3 = span[..3];
				if (prefix3.Equals("VMX", StringComparison.OrdinalIgnoreCase))
				{
					return ModelType.Appliance;
				}

				if (length >= 5)
				{
					var prefix5 = span[..5];
					if (prefix5.Equals("C9200", StringComparison.OrdinalIgnoreCase) ||
						prefix5.Equals("C9300", StringComparison.OrdinalIgnoreCase) ||
						prefix5.Equals("C9500", StringComparison.OrdinalIgnoreCase))
					{
						return ModelType.Switch;
					}
				}
			}
		}
#endif

		return ModelType.Unknown;
	}
}

