using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// By networks
	/// </summary>
	[DataContract]
	public class ByNetworks
	{
		/// <summary>
		/// Network id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Goodput
		/// </summary>
		[DataMember(Name = "goodput")]
		public int Goodput { get; set; }

		/// <summary>
		/// Response duration
		/// </summary>
		[DataMember(Name = "responseDuration")]
		public int ResponseDuration { get; set; }
	}
}
