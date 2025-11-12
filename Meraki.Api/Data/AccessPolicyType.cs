namespace Meraki.Api.Data;

/// <summary>
/// Access Policy Type
/// </summary>
[DataContract]
public enum AccessPolicyType
{
	[EnumMember(Value = "Open")]
	/// <summary>
	/// Open
	/// </summary>
	Open = 1,

	[EnumMember(Value = "Custom access policy")]
	/// <summary>
	/// Custom Access Policy
	/// </summary>
	CustomAccessPolicy,

	[EnumMember(Value = "MAC allow list")]
	/// <summary>
	/// Mac Allow List
	/// </summary>
	MacAllowList,

	[EnumMember(Value = "Sticky MAC allow list")]
	/// <summary>
	/// Sticky Mac Allow List
	/// </summary>
	StickyMacAllowList
}
