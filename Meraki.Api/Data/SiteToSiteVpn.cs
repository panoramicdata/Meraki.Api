namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSiteToSiteVpn
/// </summary>
[DataContract]
public class SiteToSiteVpn
{
	/// <summary>
	/// The site-to-site VPN mode. Can be one of 'none', 'spoke' or 'hub'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mode")]
	public SiteToSiteVpnMode Mode { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "peerSgtCapable")]
	public bool? PeerSgtCapable { get; set; }

	/// <summary>
	/// The list of VPN hubs, in order of preference. In spoke mode, at least 1 hub is required.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "hubs")]
	public List<Hub> Hubs { get; set; } = [];

	/// <summary>
	/// The list of subnets and their VPN presence.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "subnets")]
	public List<Subnet> Subnets { get; set; } = [];

	/// <summary>
	/// Configuration of subnet features
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnet")]
	public SiteToSiteVpnSubnet? Subnet { get; set; }
}
