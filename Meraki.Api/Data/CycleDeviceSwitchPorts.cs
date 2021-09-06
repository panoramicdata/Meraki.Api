using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CycleDeviceSwitchPorts
	/// </summary>
	[DataContract]
	public class DeviceSwitchPortsCycleRequest
	{
		/// <summary>
		/// List of switch ports. Example: [1, 2-5, 1_MA-MOD-8X10G_1, 1_MA-MOD-8X10G_2-1_MA-MOD-8X10G_8]
		/// </summary>
		/// <value>List of switch ports. Example: [1, 2-5, 1_MA-MOD-8X10G_1, 1_MA-MOD-8X10G_2-1_MA-MOD-8X10G_8]</value>
		[DataMember(Name = "ports", EmitDefaultValue = false)]
		public List<string> Ports { get; set; } = new();
	}
}
