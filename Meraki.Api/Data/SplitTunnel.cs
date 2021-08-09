using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Split tunnel
	/// </summary>
	[DataContract]
	public partial class SplitTunnel
	{
		/// <summary>
		/// Enabled
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Rules
		/// </summary>
		[DataMember(Name = "rules")]
		public List<SplitTunnelRules> SplitTunnelRules { get; set; } = new();
	}
}
