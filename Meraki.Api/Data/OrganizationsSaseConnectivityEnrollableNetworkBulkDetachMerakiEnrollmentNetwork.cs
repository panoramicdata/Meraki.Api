namespace Meraki.Api.Data;

/// <summary>
/// Meraki Network to be detached.
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkBulkDetachMerakiEnrollmentNetwork
{
	/// <summary>
	/// Site Enrollment ID of the site to detach
	/// </summary> 
	[DataMember(Name = "siteId")]
	public string SiteId { get; set; } = string.Empty;
}