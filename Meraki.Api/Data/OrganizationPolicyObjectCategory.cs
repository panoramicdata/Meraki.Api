namespace Meraki.Api.Data;

[DataContract]
public enum OrganizationPolicyObjectCategory
{
	[EnumMember(Value = "adaptivePolicy")]
	AdaptivePolicy = 1,

	[EnumMember(Value = "network")]
	Network,
}
