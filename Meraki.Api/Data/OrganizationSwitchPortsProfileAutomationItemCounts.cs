namespace Meraki.Api.Data;

/// <summary>
/// Count of assigned entities to a automation profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemCounts
{
	/// <summary>
	/// Count of assigned devices, ports, networks to a automation profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assigned")]
	public OrganizationSwitchPortsProfileAutomationItemCountsAssigned Assigned { get; set; } = new();
}
