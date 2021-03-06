using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchAccessControlLists
	/// </summary>
	[DataContract]
	public partial class SwitchAccessControlListRulesUpdateRequest
	{
		/// <summary>
		/// An ordered array of the access control list rules (not including the default rule). An empty array will clear the rules.
		/// </summary>
		/// <value>An ordered array of the access control list rules (not including the default rule). An empty array will clear the rules.</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<SwitchAccessControlListRule> Rules { get; set; } = null!;
	}
}
