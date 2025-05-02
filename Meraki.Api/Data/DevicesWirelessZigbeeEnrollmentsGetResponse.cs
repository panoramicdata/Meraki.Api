namespace Meraki.Api.Data;

/// <summary>
/// Response from GetDeviceWirelessZigbeeEnrollmentAsync
/// </summary>
[DataContract]
public class DevicesWirelessZigbeeEnrollmentsGetResponse
{
	/// <summary>
	/// Id to check the status of your enrollment request
	/// </summary>
	[DataMember(Name = "enrollmentId")]
	[ApiAccess(ApiAccess.Read)]
	public string? EnrollmentId { get; set; }

	/// <summary>
	/// Enrollment started at
	/// </summary>
	[DataMember(Name = "enrollmentStatus")]
	[ApiAccess(ApiAccess.Read)]
	public string? EnrollmentStartedAt { get; set; }

	/// <summary>
	/// Status of the enrollment request
	/// </summary>
	[DataMember(Name = "status")]
	[ApiAccess(ApiAccess.Read)]
	public string? Status { get; set; }

	/// <summary>
	/// GET this url to check the status of your enrollment request
	/// </summary>
	[DataMember(Name = "url")]
	[ApiAccess(ApiAccess.Read)]
	public string? Url { get; set; }

	/// <summary>
	/// Enrollment request parameters
	/// </summary>
	[DataMember(Name = "request")]
	[ApiAccess(ApiAccess.Read)]
	public DevicesWirelessZigbeeEnrollmentRequest? Request { get; set; }

	/// <summary>
	/// Door Locks
	/// </summary>
	[DataMember(Name = "doorLocks")]
	[ApiAccess(ApiAccess.Read)]
	public List<DevicesWirelessZigbeeDoorLocks>? DoorLocks { get; set; }
}
