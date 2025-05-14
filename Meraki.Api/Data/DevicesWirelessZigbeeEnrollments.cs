namespace Meraki.Api.Data;

/// <summary>
/// Response for the enrollment create request
/// </summary>
[DataContract]
public class DevicesWirelessZigbeeEnrollments
{
	/// <summary>
	/// ID to check the status of your enrollment request
	/// </summary>
	[ApiKey]
	[DataMember(Name = "enrollmentId")]
	[ApiAccess(ApiAccess.Read)]
	public string EnrollmentId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the enrollment request
	/// </summary>
	[DataMember(Name = "status")]
	[ApiAccess(ApiAccess.Read)]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your enrollment request
	/// </summary>
	[DataMember(Name = "url")]
	[ApiAccess(ApiAccess.Read)]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Enrollment request parameters
	/// </summary>
	[DataMember(Name = "request")]
	[ApiAccess(ApiAccess.Read)]
	public DevicesWirelessZigbeeEnrollmentRequest Request { get; set; } = new();
}
