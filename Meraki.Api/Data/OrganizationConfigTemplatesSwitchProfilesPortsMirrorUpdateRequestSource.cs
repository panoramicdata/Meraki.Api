namespace Meraki.Api.Data;

/// <summary>
/// Source ports mirror configuration
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestSource
{
	/// <summary>
	/// Source Port filter traffic based on vlans
	/// </summary>
	[DataMember(Name = "filter")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestSourceFilter? Filter { get; set; }

	/// <summary>
	/// Array of all source ports config details
	/// </summary>
	[DataMember(Name = "ports")]
	public List<OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestSourcePort>? Ports { get; set; }
}
