namespace Meraki.Api.Data;

/// <summary>
/// Nameservers of the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterNameservers
{
	/// <summary>
	/// Addresses of the nameservers
	/// </summary>
	[DataMember(Name = "addresses")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public List<string>? Addresses { get; set; } = [];
}
