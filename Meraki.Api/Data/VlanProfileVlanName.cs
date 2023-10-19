namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile Named Vlan
/// </summary>
[DataContract]
public class VlanProfileVlanName
{
	/// <summary>
	/// Name of the VLAN, string length must be from 1 to 32 characters
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// VLAN ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanId")]
	public string? VlanId { get; set; }
}
