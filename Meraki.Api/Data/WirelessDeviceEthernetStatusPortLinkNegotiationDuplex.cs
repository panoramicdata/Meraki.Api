namespace Meraki.Api.Data;

/// <summary>
/// The duplex mode for the port
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessDeviceEthernetStatusPortLinkNegotiationDuplex
{
	/// <summary>
	/// Full
	/// </summary>
	[EnumMember(Value = "full")]
	Full = 1,


	/// <summary>
	/// Half
	/// </summary>
	[EnumMember(Value = "half")]
	Half = 2
}
