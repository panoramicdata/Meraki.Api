namespace Meraki.Api.Data;

/// <summary>
/// RenewOrganizationLicensesSeats
/// </summary>
[DataContract]
public class LicenseSeatsRenewalRequest
{
	/// <summary>
	/// The ID of the SM license to renew. This license must already be assigned to an SM network
	/// </summary>
	/// <value>The ID of the SM license to renew. This license must already be assigned to an SM network</value>
	[DataMember(Name = "licenseIdToRenew")]
	public string LicenseIdToRenew { get; set; } = string.Empty;
	/// <summary>
	/// The SM license to use to renew the seats on 'licenseIdToRenew'. This license must have at least as many seats available as there are seats on 'licenseIdToRenew'
	/// </summary>
	/// <value>The SM license to use to renew the seats on 'licenseIdToRenew'. This license must have at least as many seats available as there are seats on 'licenseIdToRenew'</value>
	[DataMember(Name = "unusedLicenseId")]
	public string UnusedLicenseId { get; set; } = string.Empty;
}
