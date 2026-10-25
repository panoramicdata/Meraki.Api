namespace Meraki.Api.Data;

/// <summary>
/// NeighborExplicitOutboundRouteAdvertisement
/// </summary>
[DataContract]
public class NeighborExplicitOutboundRouteAdvertisement
{
	/// <summary>
	/// Whether explicit outbound routes are advertised to the eBGP neighbor
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
