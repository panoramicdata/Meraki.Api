namespace Meraki.Api.Data;

/// <summary>
/// Device that saw the server.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenSeenByItem
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
}