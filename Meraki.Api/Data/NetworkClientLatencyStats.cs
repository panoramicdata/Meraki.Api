using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network Client Latency Stats
	/// </summary>
	[DataContract]
	public class NetworkClientLatencyStats
	{
		/// <summary>
		/// mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// latencyStats
		/// </summary>
		[DataMember(Name = "latencyStats")]
		public LatencyStats LatencyStats { get; set; } = null!;
	}
}
