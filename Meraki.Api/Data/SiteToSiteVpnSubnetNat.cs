namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSiteToSiteVpnSubnetNat - Undocumented
/// </summary>
[DataContract]
public class SiteToSiteVpnSubnetNat
{
	/// <summary>
	/// If enabled, VPN subnet translation can be used to translate any local subnets 
	/// that are allowed to use the VPN into a new subnet with the same number of addresses.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isAllowed")]
	public bool? IsAllowed { get; set; }
}
