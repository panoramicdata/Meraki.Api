using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Ports
/// </summary>
[DataContract]
public class StackDeviceSwitchPorts
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public StackDeviceSwitchPortsCounts Counts { get; set; } = new();
}
