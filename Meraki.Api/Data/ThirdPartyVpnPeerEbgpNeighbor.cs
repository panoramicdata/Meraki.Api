namespace Meraki.Api.Data;

/// <summary>
/// The BGP neighbor configuration for the VPN peer. Supported only for MX 19.1 and above.
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerEbgpNeighbor
{
	/// <summary>
	/// The eBGP hold timer in seconds for each neighbor. The eBGP hold timer must be an integer between 12 and 240.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ebgpHoldTimer")]
	public int? EbgpHoldTimer { get; set; }

	/// <summary>
	/// Configure this if the neighbor is not adjacent. The eBGP multi-hop must be an integer between 1 and 255.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ebgpMultihop")]
	public int? EbgpMultihop { get; set; }

	/// <summary>
	/// The IP version of the neighbor, enum = [4, 6]
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipVersion")]
	public int? IpVersion { get; set; }

	/// <summary>
	/// Configures the local metric associated with routes received from the remote peer. Routes from peers with lower metrics are will be preferred. Must be an integer between 0 and 4294967295. MED is 6th in the decision tree when identical routes from multiple peers exis
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "multiExitDiscriminator")]
	public int? MultiExitDiscriminator { get; set; }

	/// <summary>
	/// ID of ebgp neighbor
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "neighborId")]
	public int? NeighborId { get; set; }

	/// <summary>
	/// Remote ASN of the neighbor. The remote ASN must be an integer between 1 and 4294967295.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "remoteAsNumber")]
	public long? RemoteAsNumber { get; set; }

	/// <summary>
	/// Configures the local metric associated with routes received from the remote peer. Routes from peers with lower metrics are will be preferred. Must be an integer between 0 and 4294967295. MED is 6th in the decision tree when identical routes from multiple peers exist.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "weight")]
	public long? Weight { get; set; }

	/// <summary>
	/// IPv4/IPv6 address of the neighbor.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "neighborIp")]
	public string? neighborIp { get; set; }

	/// <summary>
	/// Source IP of eBGP neighbor
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sourceIp")]
	public string? SourceIp { get; set; }

	/// <summary>
	/// Prepends the AS_PATH BGP Attribute associated with routes received from the remote peer. 
	/// Configurable value of ASNs to prepend. Length of the array may not exceed 10, 
	/// and each ASN in the array must be an integer between 1 and 4294967295. 
	/// AS_PATH is 4th in the decision tree when identical routes from multiple peers exist.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "pathPrepend")]
	public List<int>? pathPrepend { get; set; }
}
