namespace Meraki.Api.Data;

/// <summary>
/// The PoE Power Mode for the AP
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessDeviceEthernetStatusPowerMode
{
	[EnumMember(Value = "full")]
	/// <summary>
	/// Full
	/// </summary>
	Full = 1,

	[EnumMember(Value = "low")]
	/// <summary>
	/// Low
	/// </summary>
	Low = 2
}
