using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkUplinkSettings
	/// </summary>
	[DataContract]
	public class UplinkSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets BandwidthLimits
		/// </summary>
		[DataMember(Name = "bandwidthLimits")]
		public BandwidthLimits7 BandwidthLimits { get; set; } = null!;
	}
}
