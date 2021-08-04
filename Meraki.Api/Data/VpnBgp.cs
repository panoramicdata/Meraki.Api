using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Vpn Bgp
	/// </summary>
	[DataContract]
	public class VpnBgp
	{
		/// <summary>
		/// Enabled
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// As number
		/// </summary>
		[DataMember(Name = "asNumber")]
		public int AsNumber { get; set; }

		/// <summary>
		/// IBGP hold timer
		/// </summary>
		[DataMember(Name = "ibgpHoldTimer")]
		public int IbgpHoldTimer { get; set; }

		/// <summary>
		/// Neighbors
		/// </summary>
		[DataMember(Name = "enabled")]
		public List<Neighbors> Neighbors { get; set; } = new();
	}
}
