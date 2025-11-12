namespace Meraki.Api.Data;

/// <summary>
/// Organization Policy Object Type
/// </summary>
[DataContract]
public enum OrganizationPolicyObjectType
{
	/// <summary>
	/// Cidr
	/// </summary>
	[EnumMember(Value = "cidr")]
	Cidr = 1,


	/// <summary>
	/// Adaptive Policy Ipv4Cidr
	/// </summary>
	[EnumMember(Value = "adaptivePolicyIpv4Cidr")]
	AdaptivePolicyIpv4Cidr,


	/// <summary>
	/// Fqdn
	/// </summary>
	[EnumMember(Value = "fqdn")]
	Fqdn,


	/// <summary>
	/// Ip And Mask
	/// </summary>
	[EnumMember(Value = "ipAndMask")]
	IpAndMask
}
