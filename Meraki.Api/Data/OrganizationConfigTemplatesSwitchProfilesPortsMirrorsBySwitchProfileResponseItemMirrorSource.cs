namespace Meraki.Api.Data;

/// <summary>
/// Source ports mirror configuration
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseItemMirrorSource
{
	/// <summary>
	/// Source Port filter traffic based on vlans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filter")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseItemMirrorSourceFilter Filter { get; set; } = new();

	/// <summary>
	/// Array of all source ports config details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseItemMirrorSourcePort> Ports { get; set; } = [];
}
