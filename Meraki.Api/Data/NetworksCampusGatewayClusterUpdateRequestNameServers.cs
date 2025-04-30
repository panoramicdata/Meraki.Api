namespace Meraki.Api.Data;

/// <summary>
/// Nameservers of the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestNameServers
{
	/// <summary>
	/// Addresses of the namservers
	/// </summary>
	[DataMember(Name = "addresses")]
	public List<string> Addresses { get; set; }
}