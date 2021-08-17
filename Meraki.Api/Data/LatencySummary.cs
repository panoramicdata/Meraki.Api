using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Latency summary
	/// </summary>
	public partial class LatencySummary
	{
		/// <summary>
		/// Sender uplink
		/// </summary>
		[DataMember(Name = "senderUplink")]
		public string SenderUplink { get; set; } = string.Empty;

		/// <summary>
		/// Receiver uplink
		/// </summary>
		[DataMember(Name = "receiverUplink")]
		public string ReceiverUplink { get; set; } = string.Empty;

		/// <summary>
		/// Average latency ms
		/// </summary>
		[DataMember(Name = "avgLatencyMs")]
		public int AvgLatencyMs { get; set; } = 0;

		/// <summary>
		/// Minimum latency ms
		/// </summary>
		[DataMember(Name = "minLatencyMs")]
		public int MinLatencyMs { get; set; } = 0;

		/// <summary>
		/// Maximum latency ms
		/// </summary>
		[DataMember(Name = "maxLatencyMs")]
		public int MaxLatencyMs { get; set; } = 0;
	}
}
