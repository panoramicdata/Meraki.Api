namespace Meraki.Api.Data;

/// <summary>
/// Subnets
/// </summary>
[DataContract]
public class DhcpSubnets
{
	/// <summary>
	/// Subnet
	/// </summary>
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// Vlan id
	/// </summary>
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; }

	/// <summary>
	/// Used count
	/// </summary>
	[DataMember(Name = "usedCount")]
	public int UsedCount { get; set; }

	/// <summary>
	/// Free count
	/// </summary>
	[DataMember(Name = "freeCount")]
	public int FreeCount { get; set; }
}
