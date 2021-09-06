using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The bandwidth settings for clients bound to your group policy.
	/// </summary>
	[DataContract]
	public class Bandwidth
	{
		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings")]
		public Setting Settings { get; set; }
		/// <summary>
		/// Gets or Sets BandwidthLimits
		/// </summary>
		[DataMember(Name = "bandwidthLimits")]
		public BandwidthLimits BandwidthLimits { get; set; } = null!;
	}
}
