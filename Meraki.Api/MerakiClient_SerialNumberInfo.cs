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
	/// <summary>
	/// Model prefix to product type, in match order. Longer and more specific prefixes come first,
	/// so vMX and VMX are recognised before MX and the bare Z family is the last thing tried.
	/// Comparisons are ordinal, matching the prefixes Meraki publishes.
	/// </summary>
	private static readonly (string Prefix, ProductType ProductType)[] _productTypesByModelPrefix =
	[
		("vMX", ProductType.Appliance),
		("VMX", ProductType.Appliance),
		("MX", ProductType.Appliance),
		("MS", ProductType.Switch),
		("C9", ProductType.Switch),
		("MR", ProductType.Wireless),
		("CW", ProductType.Wireless),
		("MV", ProductType.Camera),
		("MG", ProductType.CellularGateway),
		("MC", ProductType.Phone),
		("MT", ProductType.Sensor),
		("Z", ProductType.Appliance),
	];

	/// <summary>
	/// The product type a model belongs to, or null where the model is unknown or unrecognised.
	/// </summary>
	private static ProductType? GetProductType(string? model)
	{
		if (model is null)
		{
			return null;
		}

		foreach (var (prefix, productType) in _productTypesByModelPrefix)
		{
			if (model.StartsWith(prefix, StringComparison.Ordinal))
			{
				return productType;
			}
		}

		return null;
	}

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

		var productType = GetProductType(model);

		var (endOfSale, endOfSupport, endOfSaleNoticeUrl) = GetEndOfLife(model);

		return new SerialNumberInfo
		{
			SerialNumber = serialNumber,
			ProductType = productType,
			IsVirtual = model?[0] == 'v',
			Model = model ?? "Unknown",
			EndOfSale = endOfSale,
			EndOfSupport = endOfSupport,
			EndOfSaleNoticeUrl = endOfSaleNoticeUrl
		};
	}

	/// <summary>
	/// The end-of-life dates published for a model, all null where the model has no EOX row. The
	/// stored dates carry no offset, so they are read as UTC.
	/// </summary>
	private static (DateTimeOffset? EndOfSale, DateTimeOffset? EndOfSupport, string? NoticeUrl) GetEndOfLife(string? model)
	{
		var eox = _eoxData.Find(row => row?["DeviceModel"]?.ToString() == model);

		return eox is null
			? (null, null, null)
			: (ReadUtcDate(eox, "EndOfSale"), ReadUtcDate(eox, "EndOfSupport"), eox["EosNoticeUrl"]?.ToString());
	}

	/// <summary>
	/// Reads a stored end-of-life date, which carries no offset and is therefore read as UTC.
	/// </summary>
	private static DateTimeOffset? ReadUtcDate(JObject row, string propertyName)
	{
		var value = row[propertyName]?.ToObject<DateTime?>();

		return value is null
			? null
			: new DateTimeOffset(value.Value, TimeSpan.Zero);
	}
}
#pragma warning restore S2333, S1118
