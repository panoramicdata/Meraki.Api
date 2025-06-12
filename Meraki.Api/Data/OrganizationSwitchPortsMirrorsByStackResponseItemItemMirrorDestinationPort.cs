namespace Meraki.Api.Data;

/// <summary>
/// Destination Port specific configuraion
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorDestinationPort
{
	/// <summary>
	/// Destination switch port number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// Destination port switch serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Destination port module object
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "module")]
	public OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorDestinationPortModule Module { get; set; } = new();
}
