using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkVlan
	/// </summary>
	[DataContract]
	public partial class CreateNetworkVlan
	{
		/// <summary>
		/// The VLAN ID of the new VLAN (must be between 1 and 4094)
		/// </summary>
		/// <value>The VLAN ID of the new VLAN (must be between 1 and 4094)</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }
		/// <summary>
		/// The name of the new VLAN
		/// </summary>
		/// <value>The name of the new VLAN</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }
		/// <summary>
		/// The subnet of the VLAN
		/// </summary>
		/// <value>The subnet of the VLAN</value>
		[DataMember(Name = "subnet", EmitDefaultValue = false)]
		public string Subnet { get; set; }
		/// <summary>
		/// The local IP of the appliance on the VLAN
		/// </summary>
		/// <value>The local IP of the appliance on the VLAN</value>
		[DataMember(Name = "applianceIp", EmitDefaultValue = false)]
		public string ApplianceIp { get; set; }
		/// <summary>
		/// The id of the desired group policy to apply to the VLAN
		/// </summary>
		/// <value>The id of the desired group policy to apply to the VLAN</value>
		[DataMember(Name = "groupPolicyId", EmitDefaultValue = false)]
		public string GroupPolicyId { get; set; }
	}
}
