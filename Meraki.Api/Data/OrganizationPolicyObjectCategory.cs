namespace Meraki.Api.Data;

/// <summary>
/// Organization Policy Object Category
/// </summary>
[DataContract]
public enum OrganizationPolicyObjectCategory
{
	[EnumMember(Value = "adaptivePolicy")]
	/// <summary>
	/// Adaptive Policy
	/// </summary>
	AdaptivePolicy = 1,

	[EnumMember(Value = "network")]
	/// <summary>
	/// Network
	/// </summary>
	Network,
}
