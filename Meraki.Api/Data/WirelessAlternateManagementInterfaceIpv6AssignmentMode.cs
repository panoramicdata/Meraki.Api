namespace Meraki.Api.Data;

/// <summary>
/// The type of address assignment. Either static or dynamic
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum WirelessAlternateManagementInterfaceIpv6AssignmentMode
{
	/// <summary>
	/// Static
	/// </summary>
	[EnumMember(Value = "static")]
	Static,

	/// <summary>
	/// Dynamic
	/// </summary>
	[EnumMember(Value = "dynamic")]
	Dynamic
}