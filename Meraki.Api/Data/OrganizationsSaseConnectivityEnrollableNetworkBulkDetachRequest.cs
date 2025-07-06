namespace Meraki.Api.Data;

/// <summary>
/// Organizations Sase Connectivity Enrollable Network Bulk Detach Request
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkBulkDetachRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public OrganizationsSaseConnectivityEnrollableNetworkBulkActionCallback? Callback { get; set; }

	/// <summary>
	/// List of Secure Access sites to be detached.
	/// </summary>
	[DataMember(Name = "merakiEnrollments")]
	public List<OrganizationsSaseConnectivityEnrollableNetworkBulkDetachMerakiEnrollment>? MerakiEnrollments { get; set; }
}
