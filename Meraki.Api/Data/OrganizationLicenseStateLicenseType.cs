namespace Meraki.Api.Data;

/// <summary>
/// Data by license type (Per-device licensing only)
/// </summary>
[DataContract]
public class OrganizationLicenseStateLicenseType
{
	/// <summary>
	/// License type
	/// </summary>
	[DataMember(Name = "licenseType")]
	public string LicenseType { get; set; } = string.Empty;

	/// <summary>
	/// Aggregated license count data for Systems Manager
	/// </summary>
	[DataMember(Name = "counts")]
	public OrganizationLicenseStateLicenseTypeCounts Counts { get; set; } = new();
}
