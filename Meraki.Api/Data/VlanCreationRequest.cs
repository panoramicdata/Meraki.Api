namespace Meraki.Api.Data;

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
	public string? Subnet { get; set; }

	/// <summary>
	/// The local IP of the appliance on the VLAN
	/// </summary>
	/// <value>The local IP of the appliance on the VLAN</value>
	[DataMember(Name = "applianceIp")]
	public string? ApplianceIp { get; set; }

	/// <summary>
	/// The id of the desired group policy to apply to the VLAN
	/// </summary>
	/// <value>The id of the desired group policy to apply to the VLAN</value>
	[DataMember(Name = "groupPolicyId")]
	public string? GroupPolicyId { get; set; }

	/// <summary>
	/// Cidr
	/// </summary>
	[DataMember(Name = "cidr")]
	public string? Cidr { get; set; }

	/// <summary>
	/// Mask
	/// </summary>
	[DataMember(Name = "mask")]
	public int? Mask { get; set; }

	/// <summary>
	/// Template VLAN Type
	/// </summary>
	[DataMember(Name = "templateVlanType")]
	public string? TemplateVlanType { get; set; }

	/// <summary>
	/// Ipv6
	/// </summary>
	[DataMember(Name = "ipv6")]
	public VlanIpv6? Ipv6 { get; set; }
}
