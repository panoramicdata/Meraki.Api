namespace Meraki.Api.Data;

/// <summary>
/// Source ports mirror configuration
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorSource
{
	/// <summary>
	/// Source Port filter traffic based on vlans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filter")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorSourceFilter Filter { get; set; } = new();

	/// <summary>
	/// Array of all source ports config details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorSourcePort> Ports { get; set; } = [];
}
