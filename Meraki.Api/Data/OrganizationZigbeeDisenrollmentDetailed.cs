namespace Meraki.Api.Data;

/// <summary>
/// Organization Zigbee Disenrollment Detailed
/// </summary>
[DataContract]
public class OrganizationZigbeeDisenrollmentDetailed
{
	/// <summary>
	/// Id to check the status of your disenrollment request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "disenrollmentId")]
	public string DisenrollmentId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the disenrollment request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your disenrollment request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Disenrollment request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public OrganizationZigbeeDisenrollmentRequest Request { get; set; } = new();

	/// <summary>
	/// Door Locks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "doorLocks")]
	public List<OrganizationZigbeeDoorLock> DoorLocks { get; set; } = [];
}
