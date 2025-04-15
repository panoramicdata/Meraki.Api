namespace Meraki.Api.Data;

/// <summary>
/// Configuration of subnet features
/// </summary>
[DataContract]
public class SiteToSiteVpnSubnet
{
	/// <summary>
	/// Configuration of NAT for subnets
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "nat")]
	public SiteToSiteVpnSubnetNat? Nat { get; set; }
}
