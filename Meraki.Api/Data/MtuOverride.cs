using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// ModelOverride
/// </summary>
[DataContract]
public class MtuOverride
{
	/// <summary>
	/// List of switch serials. Applicable only for switch network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "switches")]
	public List<string> Switches { get; set; } = new();

	/// <summary>
	/// List of switch profile IDs. Applicable only for template network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "switchProfiles")]
	public List<string> SwitchProfiles { get; set; } = new();

	/// <summary>
	/// MTU size for the switches or switch profiles.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mtuSize")]
	public int MtuSize { get; set; }
}
