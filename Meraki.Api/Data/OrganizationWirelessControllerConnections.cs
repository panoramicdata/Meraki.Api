namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Connections
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnections
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerConnectionsMetadata Meta { get; set; } = new();

	/// <summary>
	/// Access points associated with Wireless LAN controllers
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerConnectionsItem> Items { get; set; } = [];
}
