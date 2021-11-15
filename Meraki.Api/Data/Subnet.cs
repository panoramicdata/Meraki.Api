namespace Meraki.Api.Data;

/// <summary>
/// Subnet
/// </summary>
[DataContract]
public class Subnet
{
	/// <summary>
	/// The CIDR notation subnet used within the VPN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localSubnet")]
	public string LocalSubnet { get; set; } = string.Empty;

	/// <summary>
	/// Indicates the presence of the subnet in the VPN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useVpn")]
	public bool UseVpn { get; set; }
}
