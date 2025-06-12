namespace Meraki.Api.Data;

/// <summary>
/// Dhcp Server Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DhcpServerType
{
	/// <summary>
	/// Device
	/// </summary>
	[EnumMember(Value = "device")]
	Device,

	/// <summary>
	/// Discovered
	/// </summary>
	[EnumMember(Value = "discovered")]
	Discovered,

	/// <summary>
	/// Stack
	/// </summary>
	[EnumMember(Value = "stack")]
	Stack
}