using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Uplink status
	/// </summary>
	[DataContract]
	public class UplinkStatus
	{
		/// <summary>
		/// Network id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// Model
		/// </summary>
		[DataMember(Name = "model")]
		public string Model { get; set; } = string.Empty;

		/// <summary>
		/// Last reported at
		/// </summary>
		[DataMember(Name = "lastReportedAt")]
		public string LastReportedAt { get; set; } = string.Empty;

		/// <summary>
		/// Uplinks
		/// </summary>
		[DataMember(Name = "uplinks")]
		public List<Uplinks> Uplinks { get; set; } = new();
	}
}
