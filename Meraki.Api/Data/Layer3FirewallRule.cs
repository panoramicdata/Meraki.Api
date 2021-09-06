using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// L3FirewallRule
	/// </summary>
	[DataContract]
	public class Layer3FirewallRule
	{
		/// <summary>
		/// Description of the rule (optional)
		/// </summary>
		/// <value>Description of the rule (optional)</value>
		[DataMember(Name = "comment", EmitDefaultValue = false)]
		public string Comment { get; set; } = null!;

		/// <summary>
		/// &#39;allow&#39; or &#39;deny&#39; traffic specified by this rule
		/// </summary>
		/// <value>&#39;allow&#39; or &#39;deny&#39; traffic specified by this rule</value>
		[DataMember(Name = "policy", EmitDefaultValue = false)]
		public string Policy { get; set; } = null!;

		/// <summary>
		/// The type of protocol (must be &#39;tcp&#39;, &#39;udp&#39;, &#39;icmp&#39; or &#39;any&#39;)
		/// </summary>
		/// <value>The type of protocol (must be &#39;tcp&#39;, &#39;udp&#39;, &#39;icmp&#39; or &#39;any&#39;)</value>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string Protocol { get; set; } = null!;

		/// <summary>
		/// Destination port (integer in the range 1-65535), a port range (e.g. 8080-9090), or &#39;any&#39;
		/// </summary>
		/// <value>Destination port (integer in the range 1-65535), a port range (e.g. 8080-9090), or &#39;any&#39;</value>
		[DataMember(Name = "destPort", EmitDefaultValue = false)]
		public string DestinationPort { get; set; } = null!;

		/// <summary>
		/// Destination IP address (in IP or CIDR notation), a fully-qualified domain name (FQDN, if your network supports it) or &#39;any&#39;.
		/// </summary>
		/// <value>Destination IP address (in IP or CIDR notation), a fully-qualified domain name (FQDN, if your network supports it) or &#39;any&#39;.</value>
		[DataMember(Name = "destCidr", EmitDefaultValue = false)]
		public string DestinationCidr { get; set; } = null!;
	}
}
