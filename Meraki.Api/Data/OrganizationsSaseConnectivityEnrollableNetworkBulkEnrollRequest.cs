namespace Meraki.Api.Data;

/// <summary>
/// Organizations Sase Connectivity Enrollable Network Bulk Enroll Request
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollCallback? Callback { get; set; }

	/// <summary>
	/// List of Meraki SD-WAN sites with the associated regions to be enrolled.
	/// </summary>
	[DataMember(Name = "merakiEnrollments")]
	public List<OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollMerakiEnrollment>? MerakiEnrollments { get; set; }
}
