namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Power Mode History
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesPowerModeHistory
{
	/// <summary>
	/// The top-level property containing all power mode data.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessDevicesPowerModeHistoryItem> Items { get; set; } = [];
}
