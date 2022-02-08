namespace Meraki.Api.Data;

/// <summary>
/// MoveOrganizationLicensesSeats
/// </summary>
[DataContract]
public class LicenseSeatsMoveRequest
{
	/// <summary>
	/// The ID of the organization to move the SM seats to
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "destOrganizationId")]
	public string DestOrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// The ID of the SM license to move the seats from
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "licenseId")]
	public string LicenseId { get; set; } = string.Empty;

	/// <summary>
	/// The number of seats to move to the new organization. Must be less than or equal to the total number of seats of the license
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "seatCount")]
	public int? SeatCount { get; set; }
}
