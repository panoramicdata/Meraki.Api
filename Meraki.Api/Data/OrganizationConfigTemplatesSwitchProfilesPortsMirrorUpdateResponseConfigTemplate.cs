namespace Meraki.Api.Data;

/// <summary>
/// Config template of the switch profile
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateResponseConfigTemplate
{
	/// <summary>
	/// ID of config template
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the config template
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}