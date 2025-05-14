namespace Meraki.Api.Data;

/// <summary>
/// Networks Switch Ports Profile Port Access Policy Number
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksSwitchPortsProfilePortAccessPolicyNumber
{
	/// <summary>
	/// Custom access policy
	/// </summary>
	[EnumMember(Value = "Custom access policy")]
	CustomAccessPolicy,

	/// <summary>
	/// MAC allow list
	/// </summary>
	[EnumMember(Value = "MAC allow list")]
	MacAllowList,

	/// <summary>
	/// Open
	/// </summary>
	[EnumMember(Value = "Open")]
	Open,

	/// <summary>
	/// Sticky MAC allow list
	/// </summary>
	[EnumMember(Value = "Sticky MAC allow list")]
	StickyMacAllowList
}