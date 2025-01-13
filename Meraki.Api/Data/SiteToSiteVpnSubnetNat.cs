namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSiteToSiteVpnSubnetNat - Undocumented
/// </summary>
[DataContract]
public class SiteToSiteVpnSubnetNat
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isAllowed")]
	public bool? IsAllowed { get; set; }
}
