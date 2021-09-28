using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkVlan
	/// </summary>
	[DataContract]
	public class VlanCreationRequest
	{
		/// <summary>
		/// The VLAN ID of the new VLAN (must be between 1 and 4094)
		/// </summary>
		/// <value>The VLAN ID of the new VLAN (must be between 1 and 4094)</value>
		[DataMember(Name = "id")]
		public string Id { get; set; } = null!;

		/// <summary>
		/// The name of the new VLAN
		/// </summary>
		/// <value>The name of the new VLAN</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The subnet of the VLAN
		/// </summary>
		/// <value>The subnet of the VLAN</value>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = null!;

		/// <summary>
		/// The local IP of the appliance on the VLAN
		/// </summary>
		/// <value>The local IP of the appliance on the VLAN</value>
		[DataMember(Name = "applianceIp")]
		public string ApplianceIp { get; set; } = null!;

		/// <summary>
		/// The id of the desired group policy to apply to the VLAN
		/// </summary>
		/// <value>The id of the desired group policy to apply to the VLAN</value>
		[DataMember(Name = "groupPolicyId")]
		public string GroupPolicyId { get; set; } = null!;
	}
}
