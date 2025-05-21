namespace Meraki.Api.Data;

/// <summary>
/// Interface attributes of the server. Only for configured servers.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenDeviceInterface
{
	/// <summary>
	/// Interface name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Url link to interface.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}