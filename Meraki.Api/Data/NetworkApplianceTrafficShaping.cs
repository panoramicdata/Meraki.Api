using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Traffic shaping
	/// </summary>
	[DataContract]
	public class NetworkApplianceTrafficShaping
	{
		/// <summary>
		/// Global bandwidth limits
		/// </summary>
		[DataMember(Name = "globalBandwidthLimits")]
		public GlobalBandwidthLimits GlobalBandwidthLimits { get; set; } = new();
	}
}
