using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Billing
	/// </summary>
	[DataContract]
	public partial class Billing
	{
		/// <summary>
		/// Reply to email address
		/// </summary>
		[DataMember(Name = "replyToEmailAddress")]
		public string ReplyToEmailAddress { get; set; } = string.Empty;

		/// <summary>
		/// Prepaid access fast login enabled
		/// </summary>
		[DataMember(Name = "prepaidAccessFastLoginEnabled")]
		public bool PrepaidAccessFastLoginEnabled { get; set; }

		/// <summary>
		/// Free access
		/// </summary>
		[DataMember(Name = "freeAccess")]
		public FreeAccess FreeAccess { get; set; } = new();
	}
}
