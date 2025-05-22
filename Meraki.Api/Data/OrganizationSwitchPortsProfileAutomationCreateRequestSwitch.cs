namespace Meraki.Api.Data;

/// <summary>
/// Configuration settings for switch
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationCreateRequestSwitch
{
	/// <summary>
	/// Serial number of the switch
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// List of port ids
	/// </summary>
	[DataMember(Name = "portIds")]
	public List<string>? PortIds { get; set; }
}