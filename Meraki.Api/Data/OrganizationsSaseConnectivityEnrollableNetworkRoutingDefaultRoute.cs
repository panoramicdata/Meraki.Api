namespace Meraki.Api.Data;

/// <summary>
/// Default route configuration for the site
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkRoutingDefaultRoute
{
	/// <summary>
	/// Whether the site has default route enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}