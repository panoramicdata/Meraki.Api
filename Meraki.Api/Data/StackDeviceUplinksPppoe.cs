using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// PPPOE
/// </summary>
[DataContract]

public class StackDeviceUplinksPppoe
{
	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
