namespace Meraki.Api.Data;

/// <summary>
/// Device uplink addresses information
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsUnassignedItemUplink
{
	/// <summary>
	/// Available addresses for the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationWirelessControllerConnectionsUnassignedItemUplinkAddress> Addresses { get; set; } = [];
}
