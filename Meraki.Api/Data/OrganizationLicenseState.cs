namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state
/// </summary>
[DataContract]
public class OrganizationLicenseState
{
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
}
