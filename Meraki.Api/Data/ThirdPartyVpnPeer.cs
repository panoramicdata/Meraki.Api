namespace Meraki.Api.Data;

/// <summary>
/// Peer
/// </summary>
[DataContract]
public class ThirdPartyVpnPeer : NamedItem
{
	/// <summary>
	/// The public IP of the VPN peer
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "publicIp")]
	public string PublicIp { get; set; } = null!;

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
	public List<string> PrivateSubnets { get; set; } = new List<string>();

	/// <summary>
	/// Gets or Sets IpsecPolicies
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipsecPolicies")]
	public IpsecPolicies IpsecPolicies { get; set; } = new();

	/// <summary>
	/// One of the following available presets: 'default', 'aws', 'azure'. If this is provided, the 'ipsecPolicies' parameter is ignored.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipsecPoliciesPreset")]
	public string IpsecPoliciesPreset { get; set; } = string.Empty;

	/// <summary>
	/// The shared secret with the VPN peer
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "secret")]
	public string Secret { get; set; } = string.Empty;

	/// <summary>
	/// A list of network tags that will connect with this peer. Use ['all'] for all networks. Use ['none'] for no networks. If not included, the default is [&#39;all&#39;].
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "networkTags")]
	public List<string> NetworkTags { get; set; } = new List<string>();
}
