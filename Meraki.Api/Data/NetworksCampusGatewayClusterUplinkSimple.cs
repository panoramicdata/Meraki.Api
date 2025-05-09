namespace Meraki.Api.Data;

/// <summary>
/// Uplink interface details if uplink is reused as tunnel
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUplinkSimple
{
	/// <summary>
	/// Uplink interface identifier
	/// </summary>
	[DataMember(Name = "interface")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string Interface { get; set; } = string.Empty;
}