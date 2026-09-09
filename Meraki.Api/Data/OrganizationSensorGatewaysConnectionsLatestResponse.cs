namespace Meraki.Api.Data;

/// <summary>
/// Paginated list of the latest sensor gateway connections in an organization
/// </summary>
[DataContract]
public class OrganizationSensorGatewaysConnectionsLatestResponse
	: ItemsResponseWithMeta<SensorGatewayConnectionsLatestItem>
{
	/// <summary>
	/// Latest sensor gateway connections
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<SensorGatewayConnectionsLatestItem> Items { get; set; } = [];
}
