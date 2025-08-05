namespace Meraki.Api.Data;

/// <summary>
/// Source ports mirror configuration
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorSource
{
	/// <summary>
	/// Source Port filter traffic based on vlans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filter")]
	public OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorSourceFilter Filter { get; set; } = new();

	/// <summary>
	/// Source Port specific configuration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorSourcePort> Ports { get; set; } = [];
}
