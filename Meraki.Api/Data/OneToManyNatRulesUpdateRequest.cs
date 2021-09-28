using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkOneToManyNatRules
	/// </summary>
	[DataContract]
	public class OneToManyNatRulesUpdateRequest
	{
		/// <summary>
		/// An array of 1:Many nat rules
		/// </summary>
		/// <value>An array of 1:Many nat rules</value>
		[DataMember(Name = "rules")]
		public List<OneToManyNatRule> Rules { get; set; } = null!;
	}
}
