namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Uplink
/// </summary>
[DataContract]
public class NetworkCellularGatewayUplink
{
	/// <summary>
	/// Gets or Sets BandwidthLimits
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bandwidthLimits")]
	public BandwidthLimit BandwidthLimits { get; set; } = new();
}
