using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule10
	/// </summary>
	[DataContract]
	public class SsidLayer3FirewallRule
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
		/// Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;
		/// </summary>
		/// <value>Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;</value>
		[DataMember(Name = "destPort")]
		public string DestinationPort { get; set; } = null!;

		/// <summary>
		/// Comma-separated list of destination IP address(es) (in IP or CIDR notation), fully-qualified domain names (FQDN) or &#39;any&#39;
		/// </summary>
		/// <value>Comma-separated list of destination IP address(es) (in IP or CIDR notation), fully-qualified domain names (FQDN) or &#39;any&#39;</value>
		[DataMember(Name = "destCidr")]
		public string DestinationCidr { get; set; } = null!;
	}
}
