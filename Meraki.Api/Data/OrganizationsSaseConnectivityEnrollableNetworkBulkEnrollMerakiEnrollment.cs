namespace Meraki.Api.Data;

/// <summary>
/// A Meraki SD-WAN site with the associated regions to be enrolled.
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollMerakiEnrollment
{
	/// <summary>
	/// Unique identifying slug for the region to enroll the site in.
	/// </summary>
	[DataMember(Name = "region")]
	public string? Region { get; set; }

	/// <summary>
	/// Meraki SD-WAN Network to be enrolled.
	/// </summary>
	[DataMember(Name = "network")]
	public OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollMerakiEnrollmentNetwork? Network { get; set; }
}
