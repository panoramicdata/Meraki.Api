using Refit;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Meraki.Api.Data;

/// <summary>
/// Peer
/// </summary>
[DataContract]
public class ThirdPartyVpnPeer : NamedItem
{
	/// <summary>
	///	The ID of the IPsec peer
	/// </summary>
	[ApiKey]
	[DataMember(Name = "peerId")]
	public string? PeerId { get; set; }

	/// <summary>
	/// The public IP of the VPN peer
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "publicIp")]
	public string? PublicIp { get; set; }

	/// <summary>
	/// [optional] The remote ID is used to identify the connecting VPN peer. This can either be a valid IPv4 Address, FQDN or User FQDN.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "remoteId")]
	public string? RemoteId { get; set; }

	/// <summary>
	/// [optional] The IKE version to be used for the IPsec VPN peer configuration. Defaults to '1' when omitted.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ikeVersion")]
	public string? IkeVersion { get; set; }

	/// <summary>
	/// The list of the private subnets of the VPN peer
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "privateSubnets")]
	public List<string>? PrivateSubnets { get; set; }

	/// <summary>
	/// Gets or Sets IpsecPolicies
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipsecPolicies")]
	public IpsecPolicies? IpsecPolicies { get; set; }

	/// <summary>
	/// One of the following available presets: 'default', 'aws', 'azure'. If this is provided, the 'ipsecPolicies' parameter is ignored.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipsecPoliciesPreset")]
	public string? IpsecPoliciesPreset { get; set; }

	/// <summary>
	/// Local ID - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localId")]
	public string? LocalId { get; set; }

	/// <summary>
	/// The shared secret with the VPN peer
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "secret")]
	public string? Secret { get; set; }

	/// <summary>
	/// A list of network tags that will connect with this peer. Use ['all'] for all networks. Use ['none'] for no networks. If not included, the default is ['all'].
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "networkTags")]
	public List<string>? NetworkTags { get; set; }

	/// <summary>
	/// [optional] If true, the VPN peer is route-based. If not included, the default is false. Supported only for MX 19.1 and above.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isRouteBased")]
	public bool? IsRouteBased { get; set; }

	/// <summary>
	/// [optional] A list of network Names.Supported only for MX 19.1 and above.The order of items matches the order of IDs.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "network")]
	public ThirdPartyVpnPeerNetwork? Network { get; set; }

	/// <summary>
	/// [optional] Represents the order of peer inside a group
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "priorityInGroup")]
	public int? priorityInGroup { get; set; }

	/// <summary>
	/// Undocumented 2025-02-21
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "publicHostname")]
	public string? PublicHostname { get; set; }

	/// <summary>
	/// [optional] Contains the mapping between primary tunnel and backup tunnels.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "group")]
	public ThirdPartyVpnPeerGroup? Group { get; set; }

	/// <summary>
	/// [optional] Information about the SLA policy to be applied to the peer
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "slaPolicy")]
	public ThirdPartyVpnPeerSlaPolicy? SlaPolicy { get; set; }

	/// <summary>
	/// [optional] The BGP neighbor configuration for the VPN peer. Supported only for MX 19.1 and above.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ebgpNeighbor")]
	public ThirdPartyVpnPeerEbgpNeighbor? EbgpNeighbor { get; set; }
}
