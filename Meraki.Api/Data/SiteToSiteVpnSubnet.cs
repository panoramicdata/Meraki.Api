namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSiteToSiteVpnSubnet - Undocumented
/// </summary>
[DataContract]
public class SiteToSiteVpnSubnet
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "nat")]
	public SiteToSiteVpnSubnetNat? Nat { get; set; }
}
