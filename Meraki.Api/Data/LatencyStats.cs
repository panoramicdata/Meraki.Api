using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Latency Stats
	/// </summary>
	[DataContract]
	public class LatencyStats
	{
		/// <summary>
		/// backgroundTraffic
		/// </summary>
		[DataMember(Name = "backgroundTraffic")]
		public TrafficAndDistribution BackgroundTraffic { get; set; } = null!;

		/// <summary>
		/// bestEffortTraffic
		/// </summary>
		[DataMember(Name = "bestEffortTraffic")]
		public TrafficAndDistribution BestEffortTraffic { get; set; } = null!;

		/// <summary>
		/// videoTraffic
		/// </summary>
		[DataMember(Name = "videoTraffic")]
		public TrafficAndDistribution VideoTraffic { get; set; } = null!;

		/// <summary>
		/// voiceTraffic
		/// </summary>
		[DataMember(Name = "voiceTraffic")]
		public TrafficAndDistribution VoiceTraffic { get; set; } = null!;

		/// <summary>
		/// Errors
		/// </summary>
		[DataMember(Name = "errors")]
		public List<string> Errors { get; set; } = new List<string>();
	}
}
