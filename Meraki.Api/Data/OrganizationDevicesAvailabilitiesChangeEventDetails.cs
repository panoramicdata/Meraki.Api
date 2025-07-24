namespace Meraki.Api.Data;

/// <summary>
/// Details about the status changes
/// </summary>
[DataContract]
[DebuggerDisplay("{New.Count} new, {Old.Count} old")]
public class OrganizationDevicesAvailabilitiesChangeEventDetails
{
	/// <summary>
	/// Details about the new status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "new")]
	public List<OrganizationDevicesAvailabilitiesChangeEventDetail> New { get; set; } = [];

	/// <summary>
	/// Details about the old status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "old")]
	public List<OrganizationDevicesAvailabilitiesChangeEventDetail> Old { get; set; } = [];
}
