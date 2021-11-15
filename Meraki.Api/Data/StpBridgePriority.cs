using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// StpBridgePriority
/// </summary>
[DataContract]
public class StpBridgePriority
{
	/// <summary>
	/// List of switch profile IDs
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "switchProfiles")]
	public List<string>? SwitchProfiles { get; set; }

	/// <summary>
	/// List of switch serial numbers
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "switches")]
	public List<string>? Switches { get; set; }

	/// <summary>
	/// List of stack IDs
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "stacks")]
	public List<string>? Stacks { get; set; }

	/// <summary>
	/// STP priority for switch, stacks, or switch profiles
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "stpPriority")]
	public int? StpPriority { get; set; }
}
