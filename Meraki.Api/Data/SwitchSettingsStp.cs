using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSwitchSettingsStp
/// </summary>
[DataContract]
public class SwitchSettingsStp
{
	/// <summary>
	/// The spanning tree protocol status in network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rstpEnabled")]
	public bool? RstpEnabled { get; set; }
	/// <summary>
	/// STP bridge priority for switches/stacks or switch profiles. An empty array will clear the STP bridge priority settings.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "stpBridgePriority")]
	public List<StpBridgePriority> StpBridgePriority { get; set; } = new();
}
