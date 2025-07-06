namespace Meraki.Api.Data;

/// <summary>
/// Destination data for the license move
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseMoveRequestDestination
{
	/// <summary>
	/// The claim mode of the moved license
	/// </summary>
	[DataMember(Name = "mode")]
	public LicenseMode? Mode { get; set; }

	/// <summary>
	/// The organization to move the license to
	/// </summary>
	[DataMember(Name = "organizationId")]
	public string? OrganizationId { get; set; }
}