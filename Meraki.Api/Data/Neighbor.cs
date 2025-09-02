namespace Meraki.Api.Data;

/// <summary>
/// Neighbors
/// </summary>
[DataContract]
public class Neighbor
{
	/// <summary>
	/// IP address of the neighbor.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ip")]
	public string? Ip { get; set; }

	/// <summary>
	/// Remote ASN of the neighbor. The remote ASN must be an integer between 1 and 4294967295.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "remoteAsNumber")]
	public long? RemoteAsNumber { get; set; }

	/// <summary>
	/// The receive limit is the maximum number of routes that can be received from any BGP peer. The receive limit must be an integer between 0 and 4294967295. When absent, it defaults to 0.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "receiveLimit")]
	public int? ReceiveLimit { get; set; }

	/// <summary>
	/// When this feature is on, the Meraki device will advertise routes learned from other Autonomous Systems, thereby allowing traffic between Autonomous Systems to transit this AS. When absent, it defaults to false.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowTransit")]
	public bool? AllowTransit { get; set; }

	/// <summary>
	/// The output interface for peering with the remote BGP peer.Valid values are: 'wired0', 'wired1' or 'vlan{VLAN ID}'(e.g. 'vlan123').
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sourceInterface")]
	public string? SourceInterface { get; set; }

	/// <summary>
	/// The IPv4 address of the remote BGP peer that will establish a TCP session with the local MX.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "nextHopIp")]
	public string? NextHopIp { get; set; }

	/// <summary>
	/// The EBGP hold timer in seconds for each neighbor. The EBGP hold timer must be an integer between 12 and 240.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ebgpHoldTimer")]
	public int? EbgpHoldTimer { get; set; }

	/// <summary>
	/// Configure this if the neighbor is not adjacent. The EBGP multi-hop must be an integer between 1 and 255.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ebgpMultihop")]
	public int? EbgpMultihop { get; set; }

	/// <summary>
	/// Multi-exit Discriminator (MED) metric associated with routes received from the neighbor
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "multiExitDiscriminator")]
	public int? MultiExitDiscriminator { get; set; }

	/// <summary>
	/// Values to prepend to the AS_PATH BGP Attribute associated with routes received from the neighbor
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "pathPrepend")]
	public List<int>? PathPrepend { get; set; }

	/// <summary>
	/// Local weight for routes received from the neighbor
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "weight")]
	public int? Weight { get; set; }

	/// <summary>
	/// Information regarding IPv6 address of the neighbor, Required if ip is not present.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipv6")]
	public NeighborIpv6? Ipv6 { get; set; }

	/// <summary>
	/// Settings for BGP TTL security to protect BGP peering sessions from forged IP attacks.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ttlSecurity")]
	public NeighborTtlSecurity? ttlSecurity { get; set; }

	/// <summary>
	/// Authentication settings between BGP peers.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "authentication")]
	public NeighborAuthentication? Authenticaton { get; set; }
}
