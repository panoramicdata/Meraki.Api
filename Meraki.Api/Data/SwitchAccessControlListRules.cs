using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchAccessControlLists
	/// </summary>
	[DataContract]
	public class SwitchAccessControlListRules
	{
		/// <summary>
		/// An ordered array of the access control list rules (not including the default rule). An empty array will clear the rules.
		/// </summary>
		/// <value>An ordered array of the access control list rules (not including the default rule). An empty array will clear the rules.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "rules")]
		public List<SwitchAccessControlListRule> Rules { get; set; } = new();
	}
}
