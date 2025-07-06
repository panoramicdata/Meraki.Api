namespace Meraki.Api.Data;

/// <summary>
/// Sase Connectivity Enrollable Network Response
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationsSaseConnectivityEnrollableNetworkResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of sites
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationsSaseConnectivityEnrollableNetwork> Items { get; set; } = [];
}
