namespace Meraki.Api.Data;

/// <summary>
/// Assign switch port with the given profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemAssignedSwitchPort
{
	/// <summary>
	/// List of port ids
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portIds")]
	public List<string> PortIds { get; set; } = [];

	/// <summary>
	/// Switch Details
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "switch")]
	public OrganizationSwitchPortsProfileAutomationItemSwitch Switch { get; set; } = new();
}
