using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network adapter
	/// </summary>
	[DataContract]
	public class NetworkAdapter
	{
		/// <summary>
		/// DHCP server
		/// </summary>
		[DataMember(Name = "dhcpServer")]
		public string DhcpServer { get; set; } = string.Empty;

		/// <summary>
		/// DNS server
		/// </summary>
		[DataMember(Name = "dnsServer")]
		public string DnsServer { get; set; } = string.Empty;

		/// <summary>
		/// Gateway
		/// </summary>
		[DataMember(Name = "gateway")]
		public string Gateway { get; set; } = string.Empty;

		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Ip
		/// </summary>
		[DataMember(Name = "ip")]
		public string Ip { get; set; } = string.Empty;

		/// <summary>
		/// Mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Subnet
		/// </summary>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;
	}
}
