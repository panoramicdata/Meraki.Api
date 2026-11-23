namespace Meraki.Api.Data;

/// <summary>
/// Security Group Tag settings for a third-party VPN peer - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerSgt
{
	/// <summary>
	/// Whether Security Group Tags are enabled for this peer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
