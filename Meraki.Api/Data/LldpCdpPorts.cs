using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Ports
	/// </summary>
	[DataContract]
	public class LldpCdpPorts
	{
		/// <summary>
		/// 8
		/// </summary>
		[DataMember(Name = "8")]
		public Port Port8 { get; set; } = new();

		/// <summary>
		/// 12
		/// </summary>
		[DataMember(Name = "12")]
		public Port Port12 { get; set; } = new();
	}
}
