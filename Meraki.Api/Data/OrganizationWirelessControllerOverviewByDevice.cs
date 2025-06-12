namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Overview By Device
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDevice
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerOverviewByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller overview
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerOverviewByDeviceItem> Items { get; set; } = [];
}
