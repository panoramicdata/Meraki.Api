namespace Meraki.Api.Data;

/// <summary>
/// Source Port filter traffic based on vlans
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestSourceFilter
{
	/// <summary>
	/// Comma-separated VLAN IDs or ID ranges
	/// </summary>
	[DataMember(Name = "vlans")]
	public string? Vlans { get; set; }

	/// <summary>
	/// Enable the users to choose the given source vlans as transit vlans
	/// </summary>
	[DataMember(Name = "hasTransitVlan")]
	public bool? HasTransitVlan { get; set; }
}