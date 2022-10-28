namespace Meraki.Api.Data;

[DataContract]
public enum OrganizationPolicyObjectType
{
	[EnumMember(Value = "cidr")]
	Cidr = 1,

	[EnumMember(Value = "adaptivePolicyIpv4Cidr")]
	AdaptivePolicyIpv4Cidr,

	[EnumMember(Value = "fqdn")]
	Fqdn,

	[EnumMember(Value = "ipAndMask")]
	IpAndMask
}
