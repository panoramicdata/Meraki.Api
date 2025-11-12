namespace Meraki.Api.Data;

/// <summary>
/// Organization Policy Object Type
/// </summary>
[DataContract]
public enum OrganizationPolicyObjectType
{
	[EnumMember(Value = "cidr")]
	/// <summary>
	/// Cidr
	/// </summary>
	Cidr = 1,

	[EnumMember(Value = "adaptivePolicyIpv4Cidr")]
	/// <summary>
	/// Adaptive Policy Ipv4Cidr
	/// </summary>
	AdaptivePolicyIpv4Cidr,

	[EnumMember(Value = "fqdn")]
	/// <summary>
	/// Fqdn
	/// </summary>
	Fqdn,

	[EnumMember(Value = "ipAndMask")]
	/// <summary>
	/// Ip And Mask
	/// </summary>
	IpAndMask
}
