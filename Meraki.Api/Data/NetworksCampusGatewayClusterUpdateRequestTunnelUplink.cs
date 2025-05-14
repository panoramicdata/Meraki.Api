namespace Meraki.Api.Data;

/// <summary>
/// Uplink interface details if uplink is reused as tunnel
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestTunnelUplink
{
	/// <summary>
	/// Uplink interface identifier
	/// </summary>
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;
}