namespace Meraki.Api.Data;

/// <summary>
/// Destination port mirror configuration
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorDestination
{
	/// <summary>
	/// Transit or destination vlan only for RSPAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public string Vlan { get; set; } = string.Empty;

	/// <summary>
	/// Destination port config details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorDestinationPort Port { get; set; } = new();
}
