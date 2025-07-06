namespace Meraki.Api.Data;

/// <summary>
/// OSPF neighbor
/// </summary>
[DataContract]
public class DeviceLiveToolsOspfNeighborGetResponseRouter
{
	/// <summary>
	/// The VLAN ID of the OSPF neighbor
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; }

	/// <summary>
	/// The router ID in the form of an IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The Interface IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// The name of the router
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The position of the OSPF neighbor (designated router, backup designated router, or other)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "position")]
	public RouterPosition Position { get; set; }

	/// <summary>
	/// The state of the OSPF neighbor. enum = ["2-way", "attempt", "down", "exchange", "exstart", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "state")]
	public string State { get; set; } = string.Empty;
}
