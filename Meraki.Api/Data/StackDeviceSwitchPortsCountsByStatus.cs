using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// By status
/// </summary>
[DataContract]
public class StackDeviceSwitchPortsCountsByStatus
{
	/// <summary>
	/// Active
	/// </summary>
	[DataMember(Name = "active")]
	public string Active { get; set; } = string.Empty;
}
