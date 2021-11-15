using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Client VPN connections
/// </summary>
[DataContract]
public class ClientVpnConnections
{
	/// <summary>
	/// Remote IP
	/// </summary>
	[DataMember(Name = "remoteIp")]
	public string RemoteIp { get; set; } = string.Empty;

	/// <summary>
	/// Connected at
	/// </summary>
	[DataMember(Name = "connectedAt")]
	public int ConnectedAt { get; set; }

	/// <summary>
	/// Disconnected at
	/// </summary>
	[DataMember(Name = "disconnectedAt")]
	public int DisconnectedAt { get; set; }
}
