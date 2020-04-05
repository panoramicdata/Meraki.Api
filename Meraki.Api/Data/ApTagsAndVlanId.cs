using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// ApTagsAndVlanId
	/// </summary>
	[DataContract]
	public partial class ApTagsAndVlanId
	{
		/// <summary>
		/// Comma-separated list of AP tags
		/// </summary>
		/// <value>Comma-separated list of AP tags</value>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public string Tags { get; set; }
		/// <summary>
		/// Numerical identifier that is assigned to the VLAN
		/// </summary>
		/// <value>Numerical identifier that is assigned to the VLAN</value>
		[DataMember(Name = "vlanId", EmitDefaultValue = false)]
		public int? VlanId { get; set; }
	}
}
