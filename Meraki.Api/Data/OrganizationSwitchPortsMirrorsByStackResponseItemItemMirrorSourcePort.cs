namespace Meraki.Api.Data;

/// <summary>
/// Source Port configuration details
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorSourcePort
{
	/// <summary>
	/// Source port number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// Source port switch serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Source port module object
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "module")]
	public OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorSourcePortModule Module { get; set; } = new();
}
