namespace Meraki.Api.Data;

/// <summary>
/// Band to use for each flex radio. For example, ['6'] will set the AP's first flex radio to 6 GHz
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessRfProfileFlexRadiosByModelBand
{
	/// <summary>
	/// 2.4GHz
	/// </summary>
	[EnumMember(Value = "2.4")]
	Band24Ghz,

	/// <summary>
	/// 5GHz
	/// </summary>
	[EnumMember(Value = "5")]
	Band5Ghz,

	/// <summary>
	/// 6GHz
	/// </summary>
	[EnumMember(Value = "6")]
	Band6Ghz,

	/// <summary>
	/// Undocumented disabled entry
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled
}