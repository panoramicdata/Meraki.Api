namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Profile Automation
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomation
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchPortsProfileAutomationMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of automation profiles in an organization
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsProfileAutomationItem> Items { get; set; } = [];
}
