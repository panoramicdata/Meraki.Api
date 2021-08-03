using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Meraki vpn peers
	/// </summary>
	[DataContract]
	public partial class MerakiVpnPeers
	{
		/// <summary>
		/// NetworkId
		/// </summary>
		[DataMember(Name = "networkId")]
		public string networkId { get; set; } = string.Empty;

		/// <summary>
		/// Network name
		/// </summary>
		[DataMember(Name = "networkName")]
		public string NetworkName { get; set; } = string.Empty;

		/// <summary>
		/// Usage summary
		/// </summary>
		[DataMember(Name = "usageSummary")]
		public UsageSummary? UsageSummary { get; set; }

		/// <summary>
		/// Latency summaries
		/// </summary>
		[DataMember(Name = "latencySummaries")]
		public List<LatencySummary>? LatencySummaries { get; set; }

		/// <summary>
		/// Loss percentage summaries
		/// </summary>
		[DataMember(Name = "lossPercentageSummaries")]
		public List<LossPercentageSummary>? LossPercentageSummaries { get; set; }

		/// <summary>
		/// Jitter summaries
		/// </summary>
		[DataMember(Name = "jitterSummaries")]
		public List<JitterSummary>? JitterSummaries { get; set; }

		/// <summary>
		/// Mos summaries
		/// </summary>
		[DataMember(Name = "mosSummaries")]
		public List<MosSummary>? MosSummaries { get; set; }

		/// <summary>
		/// Reachability
		/// </summary>
		[DataMember(Name = "reachability")]
		public string? Reachability { get; set; }
	}
}
