namespace Meraki.Api.Data;

/// <summary>
/// Aggregated data for Systems Manager licenses (Per-device licensing only)
/// </summary>
[DataContract]
public class OrganizationLicenseStateSystemsManager
{
	/// <summary>
	/// Aggregated license count data for Systems Manager
	/// </summary>
	[DataMember(Name = "counts")]
	public OrganizationLicenseStateSystemsManagerCounts Counts { get; set; } = new();
}
