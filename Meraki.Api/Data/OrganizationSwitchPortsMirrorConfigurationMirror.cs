namespace Meraki.Api.Data;

/// <summary>
/// Switch port mirror configurations
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorConfigurationMirror
{
	/// <summary>
	/// My pretty comment
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;

	/// <summary>
	/// Switch role can be source or destination
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "role")]
	public string Role { get; set; } = string.Empty;

	/// <summary>
	/// Port mirror tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Destination port mirror configuration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destination")]
	public OrganizationSwitchPortsMirrorConfigurationMirrorDestination Destination { get; set; } = new();

	/// <summary>
	/// Source ports mirror configuration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public OrganizationSwitchPortsMirrorConfigurationMirrorSource Source { get; set; } = new();
}
