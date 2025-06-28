namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller firmware version
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItemFirmwareVersion
{
	/// <summary>
	/// Wireless LAN controller firmware version short name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "shortName")]
	public string ShortName { get; set; } = string.Empty;
}