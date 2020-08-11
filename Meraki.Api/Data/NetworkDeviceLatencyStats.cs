using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network Device Latency Stats
	/// </summary>
	[DataContract]
	public class NetworkDeviceLatencyStats
	{
		/// <summary>
		/// mac
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// latencyStats
		/// </summary>
		[DataMember(Name = "latencyStats")]
		public LatencyStats LatencyStats { get; set; } = null!;
	}
}
