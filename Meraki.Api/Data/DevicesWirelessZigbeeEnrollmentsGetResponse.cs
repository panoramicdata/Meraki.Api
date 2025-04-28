namespace Meraki.Api.Data;
public class DevicesWirelessZigbeeEnrollmentsGetResponse
{
	/// <summary>
	/// Id to check the status of your enrollment request
	/// </summary>
	[DataMember(Name = "enrollmentId")]
	public string? EnrollmentId { get; set; }

	/// <summary>
	/// Enrollment started at
	/// </summary>
	[DataMember(Name = "enrollmentStatus")]
	public string? EnrollmentStartedAt { get; set; }

	/// <summary>
	/// Status of the enrollment request
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// GET this url to check the status of your enrollment request
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// Enrollment request parameters
	/// </summary>
	[DataMember(Name = "request")]
	public DevicesWirelessZigbeeEnrollmentRequest? Request { get; set; }

	/// <summary>
	/// Door Locks
	/// </summary>
	[DataMember(Name = "doorLocks")]
	public List<DevicesWirelessZigbeeDoorLocks>? DoorLocks { get; set; }
}
