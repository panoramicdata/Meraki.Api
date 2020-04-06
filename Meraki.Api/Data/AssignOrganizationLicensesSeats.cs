using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// AssignOrganizationLicensesSeats
	/// </summary>
	[DataContract]
	public class LicenseSeatsAssignmentRequest
	{
		/// <summary>
		/// The ID of the SM license to assign seats from
		/// </summary>
		/// <value>The ID of the SM license to assign seats from</value>
		[DataMember(Name = "licenseId", EmitDefaultValue = false)]
		public string LicenseId { get; set; } = null!;

		/// <summary>
		/// The ID of the SM network to assign the seats to
		/// </summary>
		/// <value>The ID of the SM network to assign the seats to</value>
		[DataMember(Name = "networkId", EmitDefaultValue = false)]
		public string NetworkId { get; set; } = null!;

		/// <summary>
		/// The number of seats to assign to the SM network. Must be less than or equal to the total number of seats of the license
		/// </summary>
		/// <value>The number of seats to assign to the SM network. Must be less than or equal to the total number of seats of the license</value>
		[DataMember(Name = "seatCount", EmitDefaultValue = false)]
		public int? SeatCount { get; set; }
	}
}
