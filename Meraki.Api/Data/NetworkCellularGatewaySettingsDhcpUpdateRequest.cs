using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkCellularGatewaySettingsDhcp
	/// </summary>
	[DataContract]
	public class NetworkCellularGatewaySettingsDhcpUpdateRequest
	{
		/// <summary>
		/// DHCP Lease time for all MG of the network. It can be &#39;30 minutes&#39;, &#39;1 hour&#39;, &#39;4 hours&#39;, &#39;12 hours&#39;, &#39;1 day&#39; or &#39;1 week&#39;.
		/// </summary>
		/// <value>DHCP Lease time for all MG of the network. It can be &#39;30 minutes&#39;, &#39;1 hour&#39;, &#39;4 hours&#39;, &#39;12 hours&#39;, &#39;1 day&#39; or &#39;1 week&#39;.</value>
		[DataMember(Name = "dhcpLeaseTime")]
		public string DhcpLeaseTime { get; set; } = string.Empty;
		/// <summary>
		/// DNS name servers mode for all MG of the network. It can take 4 different values: &#39;upstream_dns&#39;, &#39;google_dns&#39;, &#39;opendns&#39;, &#39;custom&#39;.
		/// </summary>
		/// <value>DNS name servers mode for all MG of the network. It can take 4 different values: &#39;upstream_dns&#39;, &#39;google_dns&#39;, &#39;opendns&#39;, &#39;custom&#39;.</value>
		[DataMember(Name = "dnsNameservers")]
		public string DnsNameservers { get; set; } = string.Empty;
		/// <summary>
		/// list of fixed IP representing the DNS Name servers when the mode is &#39;custom&#39;
		/// </summary>
		/// <value>list of fixed IP representing the DNS Name servers when the mode is &#39;custom&#39;</value>
		[DataMember(Name = "dnsCustomNameservers")]
		public List<string> DnsCustomNameservers { get; set; } = new();
	}
}
