namespace Meraki.Api.Data;

/// <summary>
/// Reading
/// </summary>
[DataContract]
public class OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItemReading
{
	/// <summary>
	/// The end time of the query range
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// The start time of the query range
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Client counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItemReadingCounts Counts { get; set; } = new();
}
