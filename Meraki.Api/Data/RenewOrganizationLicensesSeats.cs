using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// RenewOrganizationLicensesSeats
	/// </summary>
	[DataContract]
	public partial class LicenseSeatsRenewalRequest
	{
		/// <summary>
		/// The ID of the SM license to renew. This license must already be assigned to an SM network
		/// </summary>
		/// <value>The ID of the SM license to renew. This license must already be assigned to an SM network</value>
		[DataMember(Name = "licenseIdToRenew", EmitDefaultValue = false)]
		public string LicenseIdToRenew { get; set; }
		/// <summary>
		/// The SM license to use to renew the seats on &#39;licenseIdToRenew&#39;. This license must have at least as many seats available as there are seats on &#39;licenseIdToRenew&#39;
		/// </summary>
		/// <value>The SM license to use to renew the seats on &#39;licenseIdToRenew&#39;. This license must have at least as many seats available as there are seats on &#39;licenseIdToRenew&#39;</value>
		[DataMember(Name = "unusedLicenseId", EmitDefaultValue = false)]
		public string UnusedLicenseId { get; set; }
	}
}
