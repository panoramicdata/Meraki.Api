namespace Meraki.Api.Data;

/// <summary>
/// Time interval snapshot of CPU usage data of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemInterval
{
	/// <summary>
	/// The end time of the query range with iso8601 format
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// The start time of the query range with iso8601 format
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// The overall CPU usage of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalOverall Overall { get; set; } = new();

	/// <summary>
	/// The CPU usage per core of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "byCore")]
	public List<OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalByCoreItem> ByCore { get; set; } = [];
}
