namespace Meraki.Api.Data;

/// <summary>
/// Organization Config Templates Switch Profiles Ports Mirrors By Switch Profile Response
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponse
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of port mirror configurations in an organization by switch profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseItem> Items { get; set; } = [];

}
