namespace Meraki.Api.Data;

/// <summary>
/// Security Group Tag settings for the VPN peer
/// </summary>
[DataContract]
public class SiteToSiteVpnSgt
{
	/// <summary>
	/// Whether Security Group Tagging is enabled for the VPN peer
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
