namespace Meraki.Api.Data;

/// <summary>
/// The duplex mode for the port
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessDeviceEthernetStatusPortLinkNegotiationDuplex
{
	[EnumMember(Value = "full")]
	/// <summary>
	/// Full
	/// </summary>
	Full = 1,

	[EnumMember(Value = "half")]
	/// <summary>
	/// Half
	/// </summary>
	Half = 2
}
