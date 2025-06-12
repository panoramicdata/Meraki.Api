namespace Meraki.Api.Data;

/// <summary>
/// Organization Config Templates Switch Profiles Ports Mirror Update Request
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequest
{
	/// <summary>
	/// My pretty comment
	/// </summary>
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// Switch role can be source or destination
	/// </summary>
	[DataMember(Name = "role")]
	public string? Role { get; set; }

	/// <summary>
	/// Port mirror tags
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// Destination port mirror configuration
	/// </summary>
	[DataMember(Name = "destination")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestDestination Destination { get; set; } = new();

	/// <summary>
	/// Source ports mirror configuration
	/// </summary>
	[DataMember(Name = "source")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestSource Source { get; set; } = new();
}
