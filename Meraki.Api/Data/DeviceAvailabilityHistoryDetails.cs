namespace Meraki.Api.Data;
/// <summary>
/// Details about the status changes
/// </summary>
[DataContract]

public class DeviceAvailabilityHistoryDetails
{
	/// <summary>
	/// Details about the new status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "new")]
	public List<DeviceAvailabilityHistoryDetailNew> New { get; set; } = [];

	/// <summary>
	/// Details about the old status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "old")]
	public List<DeviceAvailabilityHistoryDetailOld> Old { get; set; } = [];
}