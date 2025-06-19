namespace Meraki.Api.Data;

/// <summary>
/// Power Supply Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PowerSupplyStatus
{
	/// <summary>
	/// Connected
	/// </summary>
	[EnumMember(Value = "connected")]
	Connected,

	/// <summary>
	/// Not Connected
	/// </summary>
	[EnumMember(Value = "not connected")]
	NotConnected,

	/// <summary>
	/// Powering
	/// </summary>
	[EnumMember(Value = "powering")]
	Powering
}