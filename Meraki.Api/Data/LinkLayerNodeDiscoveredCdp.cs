using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Cdp
/// </summary>
[DataContract]

public class LinkLayerNodeDiscoveredCdp
{
	/// <summary>
	/// Port id
	/// </summary>
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// Native vlan
	/// </summary>
	[DataMember(Name = "nativeVlan")]
	public int NativeVlan { get; set; } = 0;
}
