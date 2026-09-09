namespace Meraki.Api.Data;

/// <summary>
/// Paginated list of campus gateway clusters in an organization
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClustersResponse
	: ItemsResponseWithMeta<OrganizationCampusGatewayCluster>
{
	/// <summary>
	/// Campus gateway clusters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<OrganizationCampusGatewayCluster> Items { get; set; } = [];
}
