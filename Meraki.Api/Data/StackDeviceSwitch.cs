using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Switch
/// </summary>
[DataContract]

public class StackDeviceSwitch
{
	/// <summary>
	/// Ports
	/// </summary>
	[DataMember(Name = "ports")]
	public StackDeviceSwitchPorts Ports { get; set; } = new();
}
