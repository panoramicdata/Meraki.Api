namespace Meraki.Api.Data;

/// <summary>
/// Assigned switch port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationCreateRequestAssignedSwitchPort
{
	/// <summary>
	/// Configuration settings for switch
	/// </summary>
	[DataMember(Name = "switch")]
	public OrganizationSwitchPortsProfileAutomationCreateRequestSwitch? Switch { get; set; }
}
