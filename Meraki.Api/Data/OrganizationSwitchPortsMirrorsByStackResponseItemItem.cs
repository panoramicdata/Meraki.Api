namespace Meraki.Api.Data;

/// <summary>
/// Port mirror configuration in an organization by switch stack
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItemItem
{
	/// <summary>
	/// Id of switch stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "switchStackId")]
	public string SwitchStackId { get; set; } = string.Empty;

	/// <summary>
	/// Warnings from traffic mirror configuration changes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warnings")]
	public List<string> Warnings { get; set; } = [];

	/// <summary>
	/// Switch port mirror configurations
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mirror")]
	public OrganizationSwitchPortsMirrorsByStackResponseItemItemMirror Mirror { get; set; } = new();

	/// <summary>
	/// Network of the switch stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationSwitchPortsMirrorsByStackResponseItemItemNetwork Network { get; set; } = new();
}
