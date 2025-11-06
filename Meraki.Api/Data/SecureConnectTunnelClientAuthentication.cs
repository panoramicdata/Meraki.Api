namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelClientAuthentication
/// </summary>
[DataContract]
public class SecureConnectTunnelClientAuthentication
{
	/// <summary>
	/// enum = "PSK" - Note : This property is currently a single value but it may be extended to support multiple values in the future.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceType")]
	public string DeviceType { get; set; } = string.Empty;

	/// <summary>
	/// The authentication context of the client.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authentication")]
	public SecureConnectTunnelClientAuthenticationParameters? Authentication { get; set; }
}
