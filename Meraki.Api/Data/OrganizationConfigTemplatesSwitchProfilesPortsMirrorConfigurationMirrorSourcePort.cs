namespace Meraki.Api.Data;

/// <summary>
/// source port config detail
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorSourcePort
{
	/// <summary>
	/// Source switch profile port number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// Source port module details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "module")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorConfigurationMirrorSourcePortModule Module { get; set; } = new();
}
