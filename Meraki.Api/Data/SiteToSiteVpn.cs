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

	/// <summary>
	/// Security Group Tag settings for the VPN peer.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sgt")]
	public SiteToSiteVpnSgt? Sgt { get; set; }

	/// <summary>
	/// The list of VPN host translations. Host translations are supported starting from MX firmware version 26.1.2
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "hostTranslations")]
	public List<SiteToSiteVpnHostTranslation>? HostTranslations { get; set; }
}
