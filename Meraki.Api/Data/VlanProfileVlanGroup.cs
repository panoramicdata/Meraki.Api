namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile Named Vlan
/// </summary>
[DataContract]
public class VlanProfileVlanGroup
{
	/// <summary>
	/// Name of the VLAN, string length must be from 1 to 32 characters
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Comma-separated VLAN IDs or ID ranges
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanIds")]
	public string? VlanIds { get; set; }
}
