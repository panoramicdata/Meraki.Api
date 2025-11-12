namespace Meraki.Api.Data;

/// <summary>
/// Access Policy Type
/// </summary>
[DataContract]
public enum AccessPolicyType
{
	/// <summary>
	/// Open
	/// </summary>
	[EnumMember(Value = "Open")]
	Open = 1,


	/// <summary>
	/// Custom Access Policy
	/// </summary>
	[EnumMember(Value = "Custom access policy")]
	CustomAccessPolicy,


	/// <summary>
	/// Mac Allow List
	/// </summary>
	[EnumMember(Value = "MAC allow list")]
	MacAllowList,


	/// <summary>
	/// Sticky Mac Allow List
	/// </summary>
	[EnumMember(Value = "Sticky MAC allow list")]
	StickyMacAllowList
}
