using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// The switch network settings
/// </summary>
[DataContract]
public class SwitchSettings
{
	/// <summary>
	/// Management VLAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// The use Combined Power as the default behavior of secondary power supplies on supported devices.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useCombinedPower")]
	public bool UseCombinedPower { get; set; }

	/// <summary>
	/// Exceptions on a per switch basis to \&quot;useCombinedPower\&quot;
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "powerExceptions")]
	public List<PowerException> PowerExceptions { get; set; } = new();
}
