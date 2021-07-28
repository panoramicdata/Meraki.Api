using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Traffic uplink preferences
	/// </summary>
	[DataContract]
	public partial class TrafficUplinkPreferences
	{
		/// <summary>
		/// Traffic filters
		/// </summary>
		[DataMember(Name = "trafficFilters")]
		public List<TrafficFilters> TrafficFilters { get; set; } = new();

		/// <summary>
		/// Preferred uplink
		/// </summary>
		[DataMember(Name = "preferredUplink")]
		public string PreferredUplink { get; set; } = string.Empty;

		/// <summary>
		/// Fail over criterion
		/// </summary>
		[DataMember(Name = "failOverCriterion")]
		public string? FailOverCriterion { get; set; }

		/// <summary>
		///	Performance class
		/// </summary>
		[DataMember(Name = "performanceClass")]
		public PerformanceClass PerformanceClass { get; set; } = new();
	}
}
