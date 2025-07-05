namespace Meraki.Api.Data;

/// <summary>
/// Network details of the cluster
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}