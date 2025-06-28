namespace Meraki.Api.Data;

/// <summary>
/// Source ports mirror configuration
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorConfigurationMirrorSource
{
	/// <summary>
	/// Source Port filter traffic based on vlans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filter")]
	public OrganizationSwitchPortsMirrorConfigurationMirrorSourceFilter Filter { get; set; } = new();

	/// <summary>
	/// Array of all source ports config details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<OrganizationSwitchPortsMirrorConfigurationMirrorSourcePort> Ports { get; set; } = [];
}
