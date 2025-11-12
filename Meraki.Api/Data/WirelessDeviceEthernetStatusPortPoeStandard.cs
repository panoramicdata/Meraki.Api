namespace Meraki.Api.Data;

/// <summary>
/// The PoE Standard for the port
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessDeviceEthernetStatusPortPoeStandard
{
	/// <summary>
	/// Standard8023at
	/// </summary>
	[EnumMember(Value = "802.3at")]
	Standard8023at = 1,

	/// <summary>
	/// Standard8023af
	/// </summary>
	[EnumMember(Value = "802.3af")]
	Standard8023af = 2,

	/// <summary>
	/// Standard8023bt
	/// </summary>
	[EnumMember(Value = "802.3bt")]
	Standard8023bt = 3
}
