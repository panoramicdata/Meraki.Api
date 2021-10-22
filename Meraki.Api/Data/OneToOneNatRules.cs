using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkOneToOneNatRules
	/// </summary>
	[DataContract]
	public class OneToOneNatRules
	{
		/// <summary>
		/// An array of 1:1 nat rules
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "rules")]
		public List<OneToOneNatRule> Rules { get; set; } = new();
	}
}
