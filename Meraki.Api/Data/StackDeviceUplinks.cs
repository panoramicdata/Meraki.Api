using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Uplinks
/// </summary>
[DataContract]

public class StackDeviceUplinks
{
	/// <summary>
	/// Vlan Id
	/// </summary>
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; } = 0;

	/// <summary>
	/// PPPOE
	/// </summary>
	[DataMember(Name = "pppoe")]
	public StackDeviceUplinksPppoe Pppoe { get; set; } = new();
}
