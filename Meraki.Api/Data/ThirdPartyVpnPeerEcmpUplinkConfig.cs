namespace Meraki.Api.Data;

/// <summary>
/// An ECMP per-uplink BGP-over-IPsec configuration for a third-party VPN peer
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerEcmpUplinkConfig
{
	/// <summary>
	/// ID of the ECMP uplink configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The WAN uplink associated with this ECMP configuration.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wan")]
	public string? Wan { get; set; }

	/// <summary>
	/// The private subnets associated with this ECMP uplink configuration.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "privateSubnets")]
	public List<string> PrivateSubnets { get; set; } = [];

	/// <summary>
	/// [optional] The eBGP neighbor configuration associated with this ECMP uplink configuration.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ebgpNeighbor")]
	public ThirdPartyVpnPeerEcmpUplinkConfigEbgpNeighbor? EbgpNeighbor { get; set; }
}
