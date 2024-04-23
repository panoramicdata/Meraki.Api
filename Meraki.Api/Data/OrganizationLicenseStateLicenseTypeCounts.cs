namespace Meraki.Api.Data;

/// <summary>
/// Aggregated count data for the license type
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationLicenseStateLicenseTypeCounts
{
	/// <summary>
	/// The number of unassigned licenses
	/// </summary>
	[DataMember(Name = "unassigned")]
	public int Unassigned { get; set; }
}
