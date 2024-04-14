namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile Named Vlan Adaptive Policy Group
/// </summary>
[DataContract]
public class VlanProfileVlanNameAdaptivePolicyGroup
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
