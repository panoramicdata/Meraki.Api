namespace Meraki.Api.Data;

/// <summary>
/// Counts of switches and ports assigned to this profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesProfileCountsAssigned
{
	/// <summary>
	/// The number of automations assigned to this profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "automations")]
	public int Automations { get; set; }

	/// <summary>
	/// The number of switch ports assigned to this profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public int Ports { get; set; }

	/// <summary>
	/// The number of switches assigned to this profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "switches")]
	public int Switches { get; set; }
}