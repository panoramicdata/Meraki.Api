namespace Meraki.Api.Data;

/// <summary>
/// Source port module object
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorSourcePortModule
{

	/// <summary>
	/// Slot of the switch module
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "slot")]
	public int Slot { get; set; }

	/// <summary>
	/// Module type of the switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}