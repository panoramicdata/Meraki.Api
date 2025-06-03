namespace Meraki.Api.Data;

/// <summary>
/// License to move
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseMoveRequestLicense
{
	/// <summary>
	/// The license key to move counts from
	/// </summary>
	[DataMember(Name = "key")]
	public string Key { get; set; } = string.Empty;

	/// <summary>
	/// The counts to move from the license by model type
	/// </summary>
	[DataMember(Name = "counts")]
	public List<OrganizationLicensingCotermLicenseMoveRequestLicenseCount> Counts { get; set; } = [];
}
