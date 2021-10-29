using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Traffic shaping
	/// </summary>
	[DataContract]
	public class TrafficShaping
	{
		/// <summary>
		/// Global per-client bandwidth limit
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "globalBandwidthLimits")]
		public GlobalBandwidthLimit GlobalBandwidthLimits { get; set; } = new();
	}
}
