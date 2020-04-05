using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkOneToManyNatRules
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkOneToManyNatRules
	{
		/// <summary>
		/// An array of 1:Many nat rules
		/// </summary>
		/// <value>An array of 1:Many nat rules</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<Rule7> Rules { get; set; }
	}
}
