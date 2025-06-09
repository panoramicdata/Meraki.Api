namespace Meraki.Api.Data;

/// <summary>
/// Use uplink interface as tunnel interface
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterTunnelUplink
{
	/// <summary>
	/// Uplink interface name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;
}