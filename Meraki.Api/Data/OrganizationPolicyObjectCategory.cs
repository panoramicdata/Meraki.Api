namespace Meraki.Api.Data;

/// <summary>
/// Organization Policy Object Category
/// </summary>
[DataContract]
public enum OrganizationPolicyObjectCategory
{
	[EnumMember(Value = "adaptivePolicy")]
	AdaptivePolicy = 1,

	[EnumMember(Value = "network")]
	Network,
}
