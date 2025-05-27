namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller overview
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItem
{
	/// <summary>
	/// Wireless LAN controller cloud ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller client and access point counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessControllerOverviewByDeviceItemCounts Counts { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller device firmware information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "firmware")]
	public OrganizationWirelessControllerOverviewByDeviceItemFirmware Firmware { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationWirelessControllerOverviewByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller redundancy information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "redundancy")]
	public OrganizationWirelessControllerOverviewByDeviceRedundancy Redundancy { get; set; } = new();
}
