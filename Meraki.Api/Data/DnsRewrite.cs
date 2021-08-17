using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// DNS servers rewrite settings
	/// </summary>
	[DataContract]
	public partial class DnsRewrite
	{
		/// <summary>
		/// Boolean indicating whether or not DNS server rewrite is enabled. If disabled, upstream DNS will be used
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// User specified DNS servers (up to two servers)
		/// </summary>
		[DataMember(Name = "dnsCustomNameservers")]
		public List<string> DnsCustomNameservers { get; set; } = new();
	}
}
