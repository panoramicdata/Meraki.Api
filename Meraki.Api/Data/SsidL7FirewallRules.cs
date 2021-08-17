using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// L 7 Firewall rules
	/// </summary>
	[DataContract]
	public class SsidL7FirewallRules
	{
		/// <summary>
		/// Rules
		/// </summary>
		[DataMember(Name = "rules")]
		public List<Rules> Rules { get; set; } = new();
	}
}
