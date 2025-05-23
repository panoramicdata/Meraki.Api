namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Packet Loss Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesPacketLossItem
{
	/// <summary>
	/// Client
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "client")]
	public OrganizationWirelessDevicesPacketLossItemClient Client { get; set; } = new();

	/// <summary>
	/// Packets sent from an AP to a client.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downstream")]
	public OrganizationWirelessDevicesPacketLossItemDownstream Downstream { get; set; } = new();

	/// <summary>
	/// Network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesPacketLossItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Packets sent from a client to an AP.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upstream")]
	public OrganizationWirelessDevicesPacketLossItemUpstream Upstream { get; set; } = new();
}
