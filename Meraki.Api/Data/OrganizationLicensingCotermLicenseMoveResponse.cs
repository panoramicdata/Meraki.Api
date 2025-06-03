namespace Meraki.Api.Data;

/// <summary>
/// Organization Licensing Coterm License Move Response
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseMoveResponse
{
	/// <summary>
	/// Newly moved licenses created in the destination organization of the license move operation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "moveLicenses")]
	public List<OrganizationLicensingCotermLicenseMoveResponseLicense> MoveLicenses { get; set; } = [];

	/// <summary>
	/// Remainder licenses created in the source organization as a result of moving a subset of the counts of a license
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remainderLicenses")]
	public List<OrganizationLicensingCotermLicenseMoveResponseLicense> RemainderLicenses { get; set; } = [];
}
