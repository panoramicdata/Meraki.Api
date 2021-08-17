using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Uplink bandwidth
	/// </summary>
	[DataContract]
	public class UplinkBandwidth
	{
		/// <summary>
		/// Bandwidth limits
		/// </summary>
		[DataMember(Name = "bandwidthLimits")]
		public BandwidthLimits7 BandwidthLimits { get; set; } = new();
	}
}
