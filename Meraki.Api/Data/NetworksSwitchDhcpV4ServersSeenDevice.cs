namespace Meraki.Api.Data;

/// <summary>
/// Attributes of the server when it's a device
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenDevice
{
	/// <summary>
	/// Device name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Device serial.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Url link to device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Interface attributes of the server. Only for configured servers.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interface")]
	public NetworksSwitchDhcpV4ServersSeenDeviceInterface Interface { get; set; } = new();
}
