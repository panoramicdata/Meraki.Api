namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Mirrors By Stack Response Item
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItem
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchPortsMirrorsByStackResponseItemMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of port mirror configurations in an organization by switch
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsMirrorsByStackResponseItemItem> Items { get; set; } = [];
}
