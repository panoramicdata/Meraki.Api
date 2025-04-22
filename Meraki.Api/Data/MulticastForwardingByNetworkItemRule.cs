namespace Meraki.Api.Data;

/// <summary>
/// MulticastForwardingByNetworkItemRule
/// </summary>
[DataContract]
public class MulticastForwardingByNetworkItemRule
{
	/// <summary>
	/// IP address
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Forwarding rule description.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// List of VLAN IDs
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlanIds")]
	public List<string> VlanIds { get; set; } = [];
}
