namespace Meraki.Api;

public partial class MerakiClient
{
	// Information from https://community.meraki.com/t5/Developers-APIs/Serial-number-to-Device-Type/m-p/199859?utm_campaign=immediate_general%27&utm_medium=email&utm_source=communitymembers
	// ...and other contributors.
	private static readonly Dictionary<string, string> _serialNumberModels = new()
	{
		{ "Q2AT", "MC74" },
		{ "Q2AW", "MS410-16" },
		{ "Q2AX", "MS120-8" },
		{ "Q2AZ", "vMX100" },
		{ "Q2BV", "MV21" },
		{ "Q2BX", "MS120-8LP" },
		{ "Q2CW", "MS425-16" },
		{ "Q2CX", "MS120-8FP" },
		{ "Q2EK", "MR84" },
		{ "Q2EV", "MV12N" },
		{ "Q2EW", "MS350-24X" },
		{ "Q2EX", "MS120-24P" },
		{ "Q2FD", "MR34" },
		{ "Q2FW", "MS225-24" },
		{ "Q2FY", "MX67" },
		{ "Q2GD", "MR18" },
		{ "Q2GV", "MV12W" },
		{ "Q2GW", "MS225-24P" },
		{ "Q2HD", "MR26" },
		{ "Q2HN", "Z1" },
		{ "Q2HP", "MS220-8P" },
		{ "Q2HV", "MV22" },
		{ "Q2HY", "MX67C-NA" },
		{ "Q2JD", "MR32" },
		{ "Q2JN", "MX100" },
		{ "Q2JP", "MS220-24" },
		{ "Q2JW", "MS225-48LP" },
		{ "Q2KD", "MR42" },
		{ "Q2KN", "MX64" },
		{ "Q2KP", "MS220-24P" },
		{ "Q2LD", "MR52" },
		{ "Q2LP", "MS220-48" },
		{ "Q2MD", "MR53" },
		{ "Q2MP", "MS220-48LP" },
		{ "Q2MY", "MX68CW-NA" },
		{ "Q2PD", "MR33" },
		{ "Q2PN", "MX84" },
		{ "Q2PW", "MS250-48LP" },
		{ "Q2PY", "Z3C-NA" },
		{ "Q2QN", "MX65" },
		{ "Q2QY", "Z3C-HW-WW" },
		{ "Q2RD", "MR30H" },
		{ "Q2SW", "MX250" },
		{ "Q2TD", "MR42E" },
		{ "Q2TN", "Z3" },
		{ "Q2TY", "MG21E" },
		{ "Q2UD", "MR53E" },
		{ "Q2VP", "MS350-24" },
		{ "Q2XD", "MR20" },
		{ "Q2XP", "MS350-48" },
		{ "Q2YD", "MR70" },
		{ "Q2ZD", "MR55" },
		{ "Q3AA", "MR45" },
		{ "Q3AB", "MR56" },
		{ "Q3AC", "MR46" },
		{ "Q3AD", "MR46E" },
	};

	/// <summary>
	/// Returns a list of end-of-life data
	/// Data regularly updated from https://documentation.meraki.com/General_Administration/Other_Topics/Meraki_End-of-Life_(EOL)_Products_and_Dates
	/// </summary>
	public static SerialNumberInfo GetInfoFromSerialNumber(string serialNumber)
	{
		if (string.IsNullOrWhiteSpace(serialNumber))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", nameof(serialNumber));
		}

		// Serial number should be in the format XXXX-XXXX-XXXX
		if (serialNumber.Length != 14)
		{
			throw new ArgumentException("Serial number should be in the format XXXX-XXXX-XXXX", nameof(serialNumber));
		}

		var model = _serialNumberModels.TryGetValue(serialNumber.Substring(0, 4), out var m)
			? m
			: throw new NotSupportedException("Serial number not recognized.");

		var productType =
			model.Contains("MX") || model.Contains("Z") ? ProductType.Appliance :
			model.Contains("MS") ? ProductType.Switch :
			model.Contains("MR") ? ProductType.Wireless :
			model.Contains("MV") ? ProductType.Camera :
			model.Contains("MG") ? ProductType.CellularGateway :
			model.Contains("MC") ? ProductType.Phone :
			model.Contains("MT") ? ProductType.Sensor :
			throw new NotSupportedException($"Model {model} not supported.");

		return new SerialNumberInfo
		{
			SerialNumber = serialNumber,
			ProductType = productType,
			IsVirtual = model[0] == 'v',
			Model = model
		};
	}
}
