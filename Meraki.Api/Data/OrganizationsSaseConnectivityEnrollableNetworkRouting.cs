namespace Meraki.Api.Data;

/// <summary>
/// Routing configuration for the site
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkRouting
{
	/// <summary>
	/// Default route configuration for the site
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "defaultRoute")]
	public OrganizationsSaseConnectivityEnrollableNetworkRoutingDefaultRoute DefaultRoute { get; set; } = new();
}
