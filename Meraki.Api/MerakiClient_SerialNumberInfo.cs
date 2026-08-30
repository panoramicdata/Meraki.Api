using Newtonsoft.Json.Linq;

namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client!
/// </summary>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333), and the class as needing a private constructor (S1118). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333, S1118
public partial class MerakiClient
{
	/// <summary>
	/// Serial number prefix to model, loaded from the SerialNumberModels.json embedded resource.
	/// </summary>
	/// <remarks>
	/// Information from https://community.meraki.com/t5/Developers-APIs/Serial-number-to-Device-Type/m-p/199859
	/// and other contributors. The table lives in a resource rather than in this file because it is
	/// data, is appended to regularly, and was long enough on its own to dominate the file. Its
	/// inline provenance comments are preserved: Newtonsoft accepts comments in JSON.
	/// </remarks>
	private static readonly Dictionary<string, string> _serialNumberModels =
		ReadEmbeddedJson<Dictionary<string, string>>("SerialNumberModels.json");

	/// <summary>
	/// End-of-life data, loaded from the EndOfLifeData.json embedded resource.
	/// </summary>
	/// <remarks>
	/// This information from a ReportMagic call: [Meraki.EndOfLife: =&gt;Array]. It is held as a
	/// resource rather than as a string literal in this file because it is a JSON document.
	/// </remarks>
	private static readonly List<JObject> _eoxData = ReadEmbeddedJson<List<JObject>>("EndOfLifeData.json");

	/// <summary>
	/// Reads one of this assembly's embedded JSON data resources.
	/// </summary>
	private static T ReadEmbeddedJson<T>(string fileName)
	{
		var resourceName = $"Meraki.Api.Data.{fileName}";
		using var stream = typeof(MerakiClient).Assembly.GetManifestResourceStream(resourceName)
			?? throw new FormatException($"The embedded resource {resourceName} is missing.");
		using var reader = new StreamReader(stream);

		return JsonConvert.DeserializeObject<T>(reader.ReadToEnd())
			?? throw new FormatException($"The embedded resource {resourceName} did not contain valid data.");
	}

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

		var model = _serialNumberModels.TryGetValue(serialNumber[..4], out var m)
			? m
			: null;

		var productType =
			model is null ? null :
			model.StartsWith("MX", StringComparison.Ordinal)
				|| model.StartsWith("vMX", StringComparison.Ordinal)
				|| model.StartsWith("VMX", StringComparison.Ordinal)
				|| model.StartsWith('Z')
					? ProductType.Appliance :
			model.StartsWith("MS", StringComparison.Ordinal)
				|| model.StartsWith("C9", StringComparison.Ordinal)
					? ProductType.Switch :
			model.StartsWith("MR", StringComparison.Ordinal)
				|| model.StartsWith("CW", StringComparison.Ordinal)
					? ProductType.Wireless :
			model.StartsWith("MV", StringComparison.Ordinal) ? ProductType.Camera :
			model.StartsWith("MG", StringComparison.Ordinal) ? ProductType.CellularGateway :
			model.StartsWith("MC", StringComparison.Ordinal) ? ProductType.Phone :
			model.StartsWith("MT", StringComparison.Ordinal) ? ProductType.Sensor :
			(ProductType?)null;

		var eox = _eoxData.Find(eox => eox?["DeviceModel"]?.ToString() == model);
		var endOfSaleDateTime = eox?["EndOfSale"]?.ToObject<DateTime?>();
		var endOfSupportDateTime = eox?["EndOfSupport"]?.ToObject<DateTime?>();
		var endOfSaleNoticeUrl = eox?["EosNoticeUrl"]?.ToString();

		return new SerialNumberInfo
		{
			SerialNumber = serialNumber,
			ProductType = productType,
			IsVirtual = model?[0] == 'v',
			Model = model ?? "Unknown",
			EndOfSale = endOfSaleDateTime is null ? null : new DateTimeOffset(endOfSaleDateTime.Value, TimeSpan.Zero),
			EndOfSupport = endOfSupportDateTime is null ? null : new DateTimeOffset(endOfSupportDateTime.Value, TimeSpan.Zero),
			EndOfSaleNoticeUrl = endOfSaleNoticeUrl
		};
	}
}
#pragma warning restore S2333, S1118
