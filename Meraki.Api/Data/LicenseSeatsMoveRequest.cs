using System.Runtime.Serialization;

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
	/// <value>The ID of the organization to move the SM seats to</value>
	[DataMember(Name = "destOrganizationId")]
	public string DestOrganizationId { get; set; } = null!;

	/// <summary>
	/// The ID of the SM license to move the seats from
	/// </summary>
	/// <value>The ID of the SM license to move the seats from</value>
	[DataMember(Name = "licenseId")]
	public string LicenseId { get; set; } = null!;

	/// <summary>
	/// The number of seats to move to the new organization. Must be less than or equal to the total number of seats of the license
	/// </summary>
	/// <value>The number of seats to move to the new organization. Must be less than or equal to the total number of seats of the license</value>
	[DataMember(Name = "seatCount")]
	public int? SeatCount { get; set; }
}
