namespace Meraki.Api.Data;

/// <summary>
/// Meraki SD-WAN Network to be enrolled.
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollMerakiEnrollmentNetwork
{
	/// <summary>
	/// Network ID of the site to enroll
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}