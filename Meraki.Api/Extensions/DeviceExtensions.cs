namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for Device
/// </summary>
public static class DeviceExtensions
{
	private static readonly Dictionary<string, ModelType> _modelTypesByExactModel = new(StringComparer.Ordinal)
	{
		["CPSC-HUB"] = ModelType.CiscoSecureConnect,
		["UMB-SIG"] = ModelType.Appliance
	};

	// Meraki model families are identified by a leading prefix. Longest prefixes are tried first so
	// that, for example, VMX is recognised as a virtual appliance rather than matching on MX.
	private static readonly Dictionary<string, ModelType> _modelTypesByPrefix = new(StringComparer.Ordinal)
	{
		["C9200"] = ModelType.Switch,
		["C9300"] = ModelType.Switch,
		["C9500"] = ModelType.Switch,
		["VMX"] = ModelType.Appliance,
		["MR"] = ModelType.WirelessLan,
		["CW"] = ModelType.WirelessLan,
		["MS"] = ModelType.Switch,
		["SM"] = ModelType.MobileDeviceManagement,
		["MG"] = ModelType.Cellular,
		["MX"] = ModelType.Appliance,
		["Z3"] = ModelType.Appliance,
		["Z4"] = ModelType.Appliance,
		["MV"] = ModelType.Camera,
		["MT"] = ModelType.Sensor
	};

	private static readonly int[] _prefixLengths = [5, 3, 2];

	/// <summary>
	/// Gets the model type for a device based on its model string
	/// </summary>
	/// <param name="device">The device</param>
	/// <returns>The model type category</returns>
	public static ModelType GetModelType(this Device device)
	{
		var model = device.Model?.ToUpperInvariant();
		if (string.IsNullOrEmpty(model))
		{
			return ModelType.Unknown;
		}

		if (_modelTypesByExactModel.TryGetValue(model, out var exactMatch))
		{
			return exactMatch;
		}

		foreach (var prefixLength in _prefixLengths)
		{
			if (model.Length >= prefixLength && _modelTypesByPrefix.TryGetValue(model[..prefixLength], out var prefixMatch))
			{
				return prefixMatch;
			}
		}

		return ModelType.Unknown;
	}
}
