namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state
/// </summary>
[DataContract]
[ApiAccessReadOnlyClass]
public class OrganizationLicenseState
{
	/// <summary>
	/// Total number of licenses (Per-device licensing only)
	/// </summary>
	[DataMember(Name = "licenseCount")]
	public int LicenseCount { get; set; }

	/// <summary>
	/// status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// status
	/// </summary>
	[DataMember(Name = "expirationDate")]
	public string ExpirationDate { get; set; } = string.Empty;

	/// <summary>
	/// Licensed device counts
	/// </summary>
	[DataMember(Name = "licensedDeviceCounts")]
	public Dictionary<string, int> LicensedDeviceCounts { get; set; } = [];

	/// <summary>
	/// Aggregated data for licenses by state (Per-device licensing only)
	/// </summary>
	[DataMember(Name = "states")]
	public OrganizationLicenseStateStates States { get; set; } = new();

	/// <summary>
	/// Aggregated data for Systems Manager licenses (Per-device licensing only)
	/// </summary>
	[DataMember(Name = "systemsManager")]
	public OrganizationLicenseStateSystemsManager SystemsManager { get; set; } = new();

	/// <summary>
	/// Data by license type (Per-device licensing only)
	/// </summary>
	[DataMember(Name = "licenseTypes")]
	public List<OrganizationLicenseStateLicenseType> LicenseTypes { get; set; } = [];
}
