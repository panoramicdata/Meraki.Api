using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Custom performance classes
	/// </summary>
	[DataContract]
	public class CustomPerformanceClassesRequest
	{
		/// <summary>
		/// Name of the custom performance class
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Maximum latency in milliseconds
		/// </summary>
		[DataMember(Name = "maxLatency")]
		public int MaxLatency { get; set; } = 0;

		/// <summary>
		/// Maximum jitter in milliseconds
		/// </summary>
		[DataMember(Name = "maxJitter")]
		public int MaxJitter { get; set; } = 0;

		/// <summary>
		/// Maximum percentage of packet loss
		/// </summary>
		[DataMember(Name = "maxLossPercentage")]
		public int MaxLossPercentage { get; set; } = 0;
	}
}
