namespace Meraki.Api.Data;

/// <summary>
/// Port Mirror configuration
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseItem
{
	/// <summary>
	/// Id of switch profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;

	/// <summary>
	/// sample warning messages from traffic mirror configuration change
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warnings")]
	public List<string> Warnings { get; set; } = [];

	/// <summary>
	/// Config template of the switch profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "configTemplate")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseItemConfigTemplate ConfigTemplate { get; set; } = new();

	/// <summary>
	/// Switch port mirror configurations
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mirror")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseItemMirror Mirror { get; set; } = new();
}
