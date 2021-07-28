using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// LAN configuration
	/// </summary>
	[DataContract]
	public class LanConfiguration
	{
		/// <summary>
		/// Subnet
		/// </summary>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;

		/// <summary>
		/// Appliance ip
		/// </summary>
		[DataMember(Name = "applianceIp")]
		public string ApplianceIp { get; set; } = string.Empty;
	}
}
