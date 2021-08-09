using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Config overrides
	/// </summary>
	[DataContract]
	public partial class ConfigOverrides
	{
		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Allowed vlans
		/// </summary>
		[DataMember(Name = "allowedVlans")]
		public string AllowedVlans { get; set; } = string.Empty;

		/// <summary>
		/// Vlan
		/// </summary>
		[DataMember(Name = "vlan")]
		public int Vlan { get; set; }
	}
}
