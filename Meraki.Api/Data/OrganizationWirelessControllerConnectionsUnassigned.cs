namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Connections Unassigned
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsUnassigned
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerConnectionsUnassignedMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of Catalyst access points information
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerConnectionsUnassignedItem> Items { get; set; } = [];
}
