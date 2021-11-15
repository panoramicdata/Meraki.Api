using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Override1
/// </summary>
[DataContract]
public class Override
{
	/// <summary>
	/// List of switch profiles ids for template network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "switchProfiles")]
	public List<string> SwitchProfiles { get; set; } = new();

	/// <summary>
	/// List of switch serials for non-template network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "switches")]
	public List<string> Switches { get; set; } = new();

	/// <summary>
	/// List of switch stack ids for non-template network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "stacks")]
	public List<string> Stacks { get; set; } = new();

	/// <summary>
	/// IGMP snooping setting for switches, switch stacks or switch profiles
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "igmpSnoopingEnabled")]
	public bool IgmpSnoopingEnabled { get; set; }

	/// <summary>
	/// Flood unknown multicast traffic setting for switches, switch stacks or switch profiles
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "floodUnknownMulticastTrafficEnabled")]
	public bool FloodUnknownMulticastTrafficEnabled { get; set; }
}
