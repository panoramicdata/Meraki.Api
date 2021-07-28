using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Channel utilization history
	/// </summary>
	[DataContract]
	public class ChannelUtilizationHistory
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
		/// Utilization total
		/// </summary>	
		[DataMember(Name = "utilizationTotal")]
		public double UtilizationTotal { get; set; } = 0;

		/// <summary>
		/// Utilization 80211
		/// </summary>
		[DataMember(Name = "utilization80211")]
		public double Utilization80211 { get; set; } = 0;

		/// <summary>
		/// Utilization non-80211
		/// </summary>
		[DataMember(Name = "utilizationNon80211")]
		public double UtilizationNon80211 { get; set; } = 0;
	}
}
