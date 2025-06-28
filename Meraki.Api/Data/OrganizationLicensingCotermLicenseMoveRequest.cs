namespace Meraki.Api.Data;

/// <summary>
/// Organization Licensing Coterm License Move Request
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseMoveRequest
{
	/// <summary>
	/// Destination data for the license move
	/// </summary>
	[DataMember(Name = "destination")]
	public OrganizationLicensingCotermLicenseMoveRequestDestination Destination { get; set; } = new();

	/// <summary>
	/// The list of licenses to move
	/// </summary>
	[DataMember(Name = "licenses")]
	public List<OrganizationLicensingCotermLicenseMoveRequestLicense> Licenses { get; set; } = [];
}
