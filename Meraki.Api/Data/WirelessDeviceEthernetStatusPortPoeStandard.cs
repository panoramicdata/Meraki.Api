namespace Meraki.Api.Data;

/// <summary>
/// The PoE Standard for the port
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessDeviceEthernetStatusPortPoeStandard
{
	[EnumMember(Value = "802.3at")]
	Standard8023at = 1,

	[EnumMember(Value = "802.3af")]
	Standard8023af = 2,

	[EnumMember(Value = "802.3bt")]
	Standard8023bt = 3
}
