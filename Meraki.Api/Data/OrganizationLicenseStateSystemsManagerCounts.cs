namespace Meraki.Api.Data;

/// <summary>
/// Aggregated license count data for Systems Manager
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationLicenseStateSystemsManagerCounts
{
	/// <summary>
	/// The number of Systems Manager seats in use
	/// </summary>
	[DataMember(Name = "activeSeats")]
	public int ActiveSeats { get; set; }

	/// <summary>
	/// The total number of enrolled Systems Manager devices
	/// </summary>
	[DataMember(Name = "orgwideEnrolledDevices")]
	public int OrgwideEnrolledDevices { get; set; }

	/// <summary>
	/// The total number of Systems Manager seats
	/// </summary>
	[DataMember(Name = "totalSeats")]
	public int TotalSeats { get; set; }

	/// <summary>
	/// The number of unused Systems Manager seats
	/// </summary>
	[DataMember(Name = "unassignedSeats")]
	public int UnassignedSeats { get; set; }
}
