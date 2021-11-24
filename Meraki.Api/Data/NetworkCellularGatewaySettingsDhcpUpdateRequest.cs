namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkCellularGatewaySettingsDhcp
/// </summary>
[DataContract]
public class NetworkCellularGatewaySettingsDhcpUpdateRequest
{
	/// <summary>
	/// DHCP Lease time for all MG of the network. It can be '30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 week'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpLeaseTime")]
	public string DhcpLeaseTime { get; set; } = string.Empty;

	/// <summary>
	/// DNS name servers mode for all MG of the network. It can take 4 different values: 'upstream_dns', 'google_dns', 'opendns', 'custom'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsNameservers")]
	public string DnsNameservers { get; set; } = string.Empty;
	/// <summary>
	/// list of fixed IP representing the DNS Name servers when the mode is 'custom'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsCustomNameservers")]
	public List<string> DnsCustomNameservers { get; set; } = new();
}
