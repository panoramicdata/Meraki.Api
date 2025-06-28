namespace Meraki.Api.Data;

/// <summary>
/// Destination port config details
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorDestinationPort
{
	/// <summary>
	/// Destination switch profile port number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// Destination port module details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "module")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorDestinationPortModule Module { get; set; } = new();
}
