using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkOneToOneNatRules
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkOneToOneNatRules
	{
		/// <summary>
		/// An array of 1:1 nat rules
		/// </summary>
		/// <value>An array of 1:1 nat rules</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<Rule8> Rules { get; set; }
	}
}
