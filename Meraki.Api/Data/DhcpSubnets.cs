using System.Runtime.Serialization;

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
	public int VlanId { get; set; } = 0;

	/// <summary>
	/// Used count
	/// </summary>
	[DataMember(Name = "usedCount")]
	public int UsedCount { get; set; } = 0;

	/// <summary>
	/// Free count
	/// </summary>
	[DataMember(Name = "freeCount")]
	public int FreeCount { get; set; } = 0;
}
