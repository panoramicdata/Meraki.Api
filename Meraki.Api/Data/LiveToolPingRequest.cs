using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Ping request
/// </summary>
[DataContract]
public class LiveToolPingRequest
{
	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Target
	/// </summary>
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;

	/// <summary>
	/// Count
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }
}
