namespace Meraki.Api.Data;

/// <summary>
/// The PoE Power Mode for the AP
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessDeviceEthernetStatusPowerMode
{
	/// <summary>
	/// Full
	/// </summary>
	[EnumMember(Value = "full")]
	Full = 1,


	/// <summary>
	/// Low
	/// </summary>
	[EnumMember(Value = "low")]
	Low = 2
}
