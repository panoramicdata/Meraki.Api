namespace Meraki.Api.Data;

/// <summary>
/// Destination port mirror configuration
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorDestination
{
	/// <summary>
	/// Transit or destination vlan only for RSPAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlan")]
	public string Vlan { get; set; } = string.Empty;

	/// <summary>
	/// Destination Port specific configuraion
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public OrganizationSwitchPortsMirrorsByStackResponseItemItemMirrorDestinationPort Port { get; set; } = new();
}
