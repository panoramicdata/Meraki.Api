namespace Meraki.Api.Data;

/// <summary>
/// Organization Policy Object Category
/// </summary>
[DataContract]
public enum OrganizationPolicyObjectCategory
{
	/// <summary>
	/// Adaptive Policy
	/// </summary>
	[EnumMember(Value = "adaptivePolicy")]
	AdaptivePolicy = 1,

	/// <summary>
	/// Network
	/// </summary>
	[EnumMember(Value = "network")]
	Network,
}
