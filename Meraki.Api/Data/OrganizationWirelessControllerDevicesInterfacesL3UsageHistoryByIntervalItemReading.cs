namespace Meraki.Api.Data;

/// <summary>
/// A usage of layer 3 interfaces of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3UsageHistoryByIntervalItemReading
{
	/// <summary>
	/// The volume of data, in bytes/sec, received by wireless controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "recv")]
	public int Recv { get; set; }

	/// <summary>
	/// The volume of data, in bytes/sec, transmitted by wireless controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "send")]
	public int Send { get; set; }

	/// <summary>
	/// The MAC address of the wireless controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The name of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}