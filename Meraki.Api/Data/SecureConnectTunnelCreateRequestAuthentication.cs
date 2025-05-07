namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelCreateRequestAuthentication
/// </summary>
[DataContract]
public class SecureConnectTunnelCreateRequestAuthentication
{
	/// <summary>
	/// The authentication method. The default is pre-shared key (PSK). enum = ["PSK"]
	/// </summary>
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Parameters
	/// </summary>
	[DataMember(Name = "parameters")]
	public SecureConnectTunnelCreateRequestAuthenticationParameters? Parameters { get; set; }
}
