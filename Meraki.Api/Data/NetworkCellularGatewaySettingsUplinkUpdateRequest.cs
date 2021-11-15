using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkCellularGatewaySettingsUplink
/// </summary>
[DataContract]
public class NetworkCellularGatewaySettingsUplinkUpdateRequest
{
	/// <summary>
	/// Gets or Sets BandwidthLimits
	/// </summary>
	[DataMember(Name = "bandwidthLimits")]
	public BandwidthLimit BandwidthLimits { get; set; } = new();
}
