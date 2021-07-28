using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// APNS certificate
	/// </summary>
	[DataContract]
	public class ApnsCert
	{
		/// <summary>
		/// Certificate
		/// </summary>
		[DataMember(Name = "certificate")]
		public string Certificate { get; set; } = string.Empty;
	}
}
