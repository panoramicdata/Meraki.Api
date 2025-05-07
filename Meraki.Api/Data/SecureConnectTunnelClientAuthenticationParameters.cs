using System.Net;

namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelClientAuthenticationParameters
/// </summary>
[DataContract]
public class SecureConnectTunnelClientAuthenticationParameters
{
	/// <summary>
	/// The PSK ID. If an IP address is used as the ID, the IP address is the value of this field.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The date and time (timestamp) that Umbrella updated the tag on the roaming computer. The timestamp is an ISO 8601 formatted string. For example: 2023-04-12T23:20:50.52Z.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "modifiedAt")]
	public DateTime modifiedAt { get; set; }
}
