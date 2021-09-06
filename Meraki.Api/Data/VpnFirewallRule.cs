using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule14
	/// </summary>
	[DataContract]
	public class VpnFirewallRule
	{
		/// <summary>
		/// Description of the rule (optional)
		/// </summary>
		/// <value>Description of the rule (optional)</value>
		[DataMember(Name = "comment")]
		public string Comment { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Policy
		/// </summary>
		[DataMember(Name = "policy")]
		public AllowOrDeny Policy { get; set; }

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol")]
		public TcpUdpIcmpAnyProtocol Protocol { get; set; }

		/// <summary>
		/// Comma-separated list of source port(s) (integer in the range 1-65535), or &#39;any&#39;
		/// </summary>
		/// <value>Comma-separated list of source port(s) (integer in the range 1-65535), or &#39;any&#39;</value>
		[DataMember(Name = "srcPort")]
		public string SourcePort { get; set; } = null!;

		/// <summary>
		/// Comma-separated list of source IP address(es) (in IP or CIDR notation), or &#39;any&#39; (FQDN not supported)
		/// </summary>
		/// <value>Comma-separated list of source IP address(es) (in IP or CIDR notation), or &#39;any&#39; (FQDN not supported)</value>
		[DataMember(Name = "srcCidr")]
		public string SourceCidr { get; set; } = null!;

		/// <summary>
		/// Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;
		/// </summary>
		/// <value>Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;</value>
		[DataMember(Name = "destPort")]
		public string DestinationPort { get; set; } = null!;
		/// <summary>
		/// Comma-separated list of destination IP address(es) (in IP or CIDR notation) or &#39;any&#39; (FQDN not supported)
		/// </summary>
		/// <value>Comma-separated list of destination IP address(es) (in IP or CIDR notation) or &#39;any&#39; (FQDN not supported)</value>
		[DataMember(Name = "destCidr")]
		public string DestinationCidr { get; set; } = null!;
		/// <summary>
		/// Log this rule to syslog (true or false, boolean value) - only applicable if a syslog has been configured (optional)
		/// </summary>
		/// <value>Log this rule to syslog (true or false, boolean value) - only applicable if a syslog has been configured (optional)</value>
		[DataMember(Name = "syslogEnabled")]
		public bool? SyslogEnabled { get; set; }
	}
}
