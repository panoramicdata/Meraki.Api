using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Ping create request
/// </summary>
[DataContract]
public class LiveToolPingCreate
{
	/// <summary>
	/// Count
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Target
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;
}
