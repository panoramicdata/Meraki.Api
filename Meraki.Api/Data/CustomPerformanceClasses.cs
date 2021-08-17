using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Custom performance classes
	/// </summary>
	[DataContract]
	public class CustomPerformanceClasses
	{
		/// <summary>
		/// Custom performance class id
		/// </summary>
		[DataMember(Name = "customPerformanceClassId")]
		public string CustomPerformanceClassId { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Max latency
		/// </summary>
		[DataMember(Name = "maxLatency")]
		public int MaxLatency { get; set; } = 0;

		/// <summary>
		/// Max jitter
		/// </summary>
		[DataMember(Name = "maxJitter")]
		public int MaxJitter { get; set; } = 0;

		/// <summary>
		/// Max loss percentage
		/// </summary>
		[DataMember(Name = "maxLossPercentage")]
		public int MaxLossPercentage { get; set; } = 0;
	}
}
