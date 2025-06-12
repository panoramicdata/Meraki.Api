namespace Meraki.Api.Data;

/// <summary>
/// List of Secure Access sites to be detached.
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkBulkDetachMerakiEnrollment
{
	/// <summary>
	/// Meraki Network to be detached.
	/// </summary> 
	[DataMember(Name = "network")]
	public OrganizationsSaseConnectivityEnrollableNetworkBulkDetachMerakiEnrollmentNetwork? Network { get; set; }
}
