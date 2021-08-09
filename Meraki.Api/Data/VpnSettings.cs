using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// VPN settings
	/// </summary>
	[DataContract]
	public class VpnSettings
	{
		/// <summary>
		/// Split tunnel
		/// </summary>
		[DataMember(Name = "splitTunnel")]
		public SplitTunnel SplitTunnel { get; set; } = new();
	}
}
