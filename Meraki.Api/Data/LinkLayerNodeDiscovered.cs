using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Discovered
/// </summary>
[DataContract]
public class LinkLayerNodeDiscovered
{
	/// <summary>
	/// Lldp
	/// </summary>
	[DataMember(Name = "lldp")]
	public LinkLayerNodeDiscoveredLldp Lldp { get; set; } = new();

	/// <summary>
	/// Cdp
	/// </summary>
	[DataMember(Name = "cdp")]
	public string Cdp { get; set; } = string.Empty;
}
