using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Ranges
	/// </summary>
	[DataContract]
	public class Ranges
	{
		/// <summary>
		/// Start day
		/// </summary>
		[DataMember(Name = "startDay")]
		public string StartDay { get; set; } = string.Empty;

		/// <summary>
		/// Start time
		/// </summary>
		[DataMember(Name = "startTime")]
		public string StartTime { get; set; } = string.Empty;

		/// <summary>
		/// End day
		/// </summary>
		[DataMember(Name = "endDay")]
		public string EndDay { get; set; } = string.Empty;

		/// <summary>
		/// End time
		/// </summary>
		[DataMember(Name = "endTime")]
		public string EndTime { get; set; } = string.Empty;
	}
}
