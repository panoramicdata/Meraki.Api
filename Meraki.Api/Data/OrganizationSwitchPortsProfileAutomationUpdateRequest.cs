namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profile Automation Update Request
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationUpdateRequest
{
	/// <summary>
	/// Text describing the port profile automation.
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Name of the port profile automation.
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Configuration settings for port profile
	/// </summary>
	[DataMember(Name = "fallbackProfile")]
	public OrganizationSwitchPortsProfileAutomationItemFallbackProfile? FallbackProfile { get; set; }

	/// <summary>
	/// Assigned switch ports
	/// </summary>
	[DataMember(Name = "assignedSwitchPorts")]
	public List<OrganizationSwitchPortsProfileAutomationCreateRequestAssignedSwitchPort>? AssignedSwitchPorts { get; set; }

	/// <summary>
	/// Configuration settings for port profile automation rules
	/// </summary>
	[DataMember(Name = "rules")]
	public List<OrganizationSwitchPortsProfileAutomationItemRule>? Rules { get; set; }
}
