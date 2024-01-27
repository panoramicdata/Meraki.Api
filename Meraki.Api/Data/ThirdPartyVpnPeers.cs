namespace Meraki.Api.Data;

/// <summary>
/// Third party vpn peers
/// </summary>
[DataContract]
public class ThirdPartyVpnPeers
{
	/// <summary>
	/// The list of VPN peers
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "peers")]
	public List<ThirdPartyVpnPeer> Peers { get; set; } = [];
}
