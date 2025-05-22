namespace Meraki.Api.Data;

/// <summary>
/// List of automation profiles in an organization
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItem
{
	/// <summary>
	/// Text describing the automation profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Switch port profile automation Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Automation port profile name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not this profile is a organization wide profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isOrganizationWide")]
	public bool IsOrganizationWide { get; set; }

	/// <summary>
	/// Type of the profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "types")]
	public List<string> Types { get; set; } = [];

	/// <summary>
	/// Count of assigned entities to a automation profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsProfileAutomationItemCounts Counts { get; set; } = new();

	/// <summary>
	/// Fallback port profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fallbackProfile")]
	public OrganizationSwitchPortsProfileAutomationItemFallbackProfile FallbackProfile { get; set; } = new();

	/// <summary>
	/// Assign switch port with the given profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "assignedSwitchPorts")]
	public List<OrganizationSwitchPortsProfileAutomationItemAssignedSwitchPort> AssignedSwitchPorts { get; set; } = [];

	/// <summary>
	/// List of Associated Networks
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networks")]
	public List<OrganizationSwitchPortsProfileAutomationItemNetwork> Networks { get; set; } = [];

	/// <summary>
	/// Automation rules configurations
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rules")]
	public List<OrganizationSwitchPortsProfileAutomationItemRule> Rules { get; set; } = [];
}
