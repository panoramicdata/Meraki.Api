using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Event data
	/// </summary>
	[DataContract]
	public class EventData
	{
		/// <summary>
		/// Client ip
		/// </summary>
		[DataMember(Name = "clientIp")]
		public string ClientIp { get; set; } = string.Empty;
	}
}
