using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
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
		public BandwidthLimits BandwidthLimits { get; set; } = new();
	}
}
