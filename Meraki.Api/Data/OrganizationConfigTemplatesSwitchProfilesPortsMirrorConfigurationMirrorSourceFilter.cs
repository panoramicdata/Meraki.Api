namespace Meraki.Api.Data;

/// <summary>
/// Source Port filter traffic based on vlans
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorSourceFilter
{
	/// <summary>
	/// Comma-separated VLAN IDs or ID ranges
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlans")]
	public string Vlans { get; set; } = string.Empty;

	/// <summary>
	/// Enable the users to choose the given source vlans as transit vlans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hasTransitVlan")]
	public bool HasTransitVlans { get; set; }
}