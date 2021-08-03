using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Guest sponsorship
	/// </summary>
	[DataContract]
	public partial class GuestSponsorship
	{
		/// <summary>
		/// Duration in minutes
		/// </summary>
		[DataMember(Name = "durationInMinutes")]
		public int DurationInMinutes { get; set; }

		/// <summary>
		/// Guest can request timeframe
		/// </summary>
		[DataMember(Name = "guestCanRequestTimeframe")]
		public bool GuestCanRequestTimeframe { get; set; }
	}
}
