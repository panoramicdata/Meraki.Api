using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Usage summary
	/// </summary>
	[DataContract]
	public partial class UsageSummary
	{
		/// <summary>
		/// Received in kilobytes
		/// </summary>
		[DataMember(Name = "receivedInKilobytes")]
		public int ReceivedInKilobytes { get; set; } = 0;

		/// <summary>
		/// Sent in kilobytes
		/// </summary>
		[DataMember(Name = "sentInKilobytes")]
		public int SentInKilobytes { get; set; } = 0;
	}
}
