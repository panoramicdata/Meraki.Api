using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The Bonjour settings for your group policy. Only valid if your network has a wireless configuration.
	/// </summary>
	[DataContract]
	public partial class BonjourForwarding
	{
		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public Setting Settings { get; set; }

		/// <summary>
		/// A list of the Bonjour forwarding rules for your group policy. If &#39;settings&#39; is set to &#39;custom&#39;, at least one rule must be specified.
		/// </summary>
		/// <value>A list of the Bonjour forwarding rules for your group policy. If &#39;settings&#39; is set to &#39;custom&#39;, at least one rule must be specified.</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<BonjourForwardingRule> Rules { get; set; } = null!;
	}
}
