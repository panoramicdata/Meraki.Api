namespace Meraki.Api.Data;

/// <summary>
/// The eBGP neighbor of an ECMP uplink configuration
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerEcmpUplinkConfigEbgpNeighbor
{
	/// <summary>
	/// The IP address of the eBGP neighbor
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "neighborIp")]
	public string? NeighborIp { get; set; }

	/// <summary>
	/// The source IP address used for the eBGP session
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sourceIp")]
	public string? SourceIp { get; set; }
}
