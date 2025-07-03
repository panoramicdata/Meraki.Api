namespace Meraki.Api.Data;

/// <summary>
/// IPsec configuration data
/// </summary>
[DataContract]
public class OrganizationApplianceVpnSiteToSiteIpsecPeersSlasItemIpsec
{
	/// <summary>
	/// Array of IPsec peer IDs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "peerIds")]
	public List<string> PeerIds { get; set; } = [];
}