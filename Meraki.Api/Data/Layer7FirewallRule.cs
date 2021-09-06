using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// L7FirewallRule
	/// </summary>
	[DataContract]
	public class Layer7FirewallRule
	{
		/// <summary>
		/// Gets or Sets Policy
		/// </summary>
		[DataMember(Name = "policy", EmitDefaultValue = false)]
		public Layer7FirewallRulePolicy Policy { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public Layer7FirewallRuleType Type { get; set; }

		/// <summary>
		/// The &#39;value&#39; of what you want to block. If &#39;type&#39; is &#39;host&#39;, &#39;port&#39; or &#39;ipRange&#39;, &#39;value&#39; must be a string matching either a hostname (e.g. somewhere.com), a port (e.g. 8080), or an IP range (e.g. 192.1.0.0/16). If &#39;type&#39; is &#39;application&#39; or &#39;applicationCategory&#39;, then &#39;value&#39; must be an object with an ID for the application.
		/// </summary>
		/// <value>The &#39;value&#39; of what you want to block. If &#39;type&#39; is &#39;host&#39;, &#39;port&#39; or &#39;ipRange&#39;, &#39;value&#39; must be a string matching either a hostname (e.g. somewhere.com), a port (e.g. 8080), or an IP range (e.g. 192.1.0.0/16). If &#39;type&#39; is &#39;application&#39; or &#39;applicationCategory&#39;, then &#39;value&#39; must be an object with an ID for the application.</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; } = null!;
	}
}
