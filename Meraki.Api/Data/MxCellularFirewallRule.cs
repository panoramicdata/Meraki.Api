using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule1
	/// </summary>
	[DataContract]
	public partial class MxCellularFirewallRule
	{
		/// <summary>
		/// Description of the rule (optional)
		/// </summary>
		/// <value>Description of the rule (optional)</value>
		[DataMember(Name = "comment", EmitDefaultValue = false)]
		public string Comment { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Policy
		/// </summary>
		[DataMember(Name = "policy", EmitDefaultValue = false)]
		public Policy Policy { get; set; }

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public Protocol Protocol { get; set; }

		/// <summary>
		/// Comma-separated list of source port(s) (integer in the range 1-65535), or &#39;any&#39;
		/// </summary>
		/// <value>Comma-separated list of source port(s) (integer in the range 1-65535), or &#39;any&#39;</value>
		[DataMember(Name = "srcPort", EmitDefaultValue = false)]
		public string SrcPort { get; set; } = null!;

		/// <summary>
		/// Comma-separated list of source IP address(es) (in IP or CIDR notation), or &#39;any&#39; (note: FQDN not supported for source addresses)
		/// </summary>
		/// <value>Comma-separated list of source IP address(es) (in IP or CIDR notation), or &#39;any&#39; (note: FQDN not supported for source addresses)</value>
		[DataMember(Name = "srcCidr", EmitDefaultValue = false)]
		public string SrcCidr { get; set; } = null!;

		/// <summary>
		/// Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;
		/// </summary>
		/// <value>Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;</value>
		[DataMember(Name = "destPort", EmitDefaultValue = false)]
		public string DestPort { get; set; } = null!;

		/// <summary>
		/// Comma-separated list of destination IP address(es) (in IP or CIDR notation), fully-qualified domain names (FQDN) or &#39;any&#39;
		/// </summary>
		/// <value>Comma-separated list of destination IP address(es) (in IP or CIDR notation), fully-qualified domain names (FQDN) or &#39;any&#39;</value>
		[DataMember(Name = "destCidr", EmitDefaultValue = false)]
		public string DestCidr { get; set; } = null!;

		/// <summary>
		/// Log this rule to syslog (true or false, boolean value) - only applicable if a syslog has been configured (optional)
		/// </summary>
		/// <value>Log this rule to syslog (true or false, boolean value) - only applicable if a syslog has been configured (optional)</value>
		[DataMember(Name = "syslogEnabled", EmitDefaultValue = false)]
		public bool? SyslogEnabled { get; set; }
	}
}
