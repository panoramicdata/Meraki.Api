using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkCellularGatewaySettingsUplink
	/// </summary>
	[DataContract]
	public partial class NetworkCellularGatewaySettingsUplinkUpdateRequest
	{
		/// <summary>
		/// Gets or Sets BandwidthLimits
		/// </summary>
		[DataMember(Name = "bandwidthLimits", EmitDefaultValue = false)]
		public BandwidthLimits BandwidthLimits { get; set; } = new();
	}
}
