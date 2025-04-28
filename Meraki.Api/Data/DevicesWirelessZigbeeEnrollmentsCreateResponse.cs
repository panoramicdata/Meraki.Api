namespace Meraki.Api.Data;

/// <summary>
/// Response for the enrollment create request
/// </summary>
public class DevicesWirelessZigbeeEnrollmentsCreateResponse
{
	/// <summary>
	/// ID to check the status of your enrollment request
	/// </summary>
	[DataMember(Name = "enrollmentId")]
	public string? EnrollmentId { get; set; }

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
}
