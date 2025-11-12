namespace Meraki.Api.Data;

/// <summary>
/// The PoE Standard for the port
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessDeviceEthernetStatusPortPoeStandard
{
	[EnumMember(Value = "802.3at")]
	/// <summary>
	/// Standard8023at
	/// </summary>
	Standard8023at = 1,

	[EnumMember(Value = "802.3af")]
	/// <summary>
	/// Standard8023af
	/// </summary>
	Standard8023af = 2,

	[EnumMember(Value = "802.3bt")]
	/// <summary>
	/// Standard8023bt
	/// </summary>
	Standard8023bt = 3
}
