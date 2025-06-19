namespace Meraki.Api.Data;

/// <summary>
/// Available address for the interface
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsUnassignedItemUplinkAddress
{
	/// <summary>
	/// Device uplink address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;
}