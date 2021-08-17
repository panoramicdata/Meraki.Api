using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Latency history
	/// </summary>
	[DataContract]
	public class LatencyHistory
	{
		/// <summary>
		/// startTs
		/// </summary>
		[DataMember(Name = "startTs")]
		public string StartTs { get; set; } = string.Empty;

		/// <summary>
		/// endTs
		/// </summary>
		[DataMember(Name = "endTs")]
		public string EndTs { get; set; } = string.Empty;

		/// <summary>
		/// Average latency Ms
		/// </summary>
		[DataMember(Name = "avgLatencyMs")]
		public int AvgLatencyMs { get; set; } = 0;
	}
}
