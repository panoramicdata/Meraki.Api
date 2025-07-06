namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller device firmware information
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItemFirmware
{
	/// <summary>
	/// Wireless LAN controller firmware version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "version")]
	public OrganizationWirelessControllerOverviewByDeviceItemFirmwareVersion Version { get; set; } = new();
}
