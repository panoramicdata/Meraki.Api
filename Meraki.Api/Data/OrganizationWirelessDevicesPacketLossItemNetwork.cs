namespace Meraki.Api.Data;

/// <summary>
/// Network.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesPacketLossItemNetwork
{
	/// <summary>
	/// Network ID.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}