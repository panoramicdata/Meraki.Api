namespace Meraki.Api.Data;

/// <summary>
/// The duplex mode for the port
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessDeviceEthernetStatusPortLinkNegotiationDuplex
{
	[EnumMember(Value = "full")]
	Full = 1,

	[EnumMember(Value = "half")]
	Half = 2
}
