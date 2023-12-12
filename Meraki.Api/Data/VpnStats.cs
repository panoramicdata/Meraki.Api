namespace Meraki.Api.Data;

/// <summary>
/// VPN Stats
/// </summary>
[DataContract]
public class VpnStats
{
	/// <summary>
	/// NetworkId
	/// </summary>
	[DataMember(Name = "networkId")]
	public string networkId { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[DataMember(Name = "networkName")]
	public string NetworkName { get; set; } = string.Empty;

	/// <summary>
	/// Usage summary
	/// </summary>
	[DataMember(Name = "merakiVpnPeers")]
	public List<MerakiVpnPeers> MerakiVpnPeers { get; set; } = [];
}
