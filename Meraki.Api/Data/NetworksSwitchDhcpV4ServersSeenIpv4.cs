namespace Meraki.Api.Data;

/// <summary>
/// IPv4 attributes of the server.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenIpv4
{
	/// <summary>
	/// IPv4 address of the server.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// IPv4 gateway address of the server.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gateway")]
	public string Gateway { get; set; } = string.Empty;

	/// <summary>
	/// Subnet of the server.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;
}