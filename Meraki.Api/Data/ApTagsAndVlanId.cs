using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// ApTagsAndVlanId
	/// </summary>
	[DataContract]
	public class ApTagsAndVlanId
	{
		/// <summary>
		/// Comma-separated list of AP tags
		/// </summary>
		/// <value>Comma-separated list of AP tags</value>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();
		/// <summary>
		/// Numerical identifier that is assigned to the VLAN
		/// </summary>
		/// <value>Numerical identifier that is assigned to the VLAN</value>
		[DataMember(Name = "vlanId")]
		public int? VlanId { get; set; }
	}
}
