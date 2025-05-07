namespace Meraki.Api.Data;

/// <summary>
/// The type of service to associate with the tunnel. The default value is SIG.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SecureConnectTunnelServiceType
{
	/// <summary>
	/// SIG
	/// </summary>
	[EnumMember(Value = "SIG")]
	SIG,

	/// <summary>
	/// Private Access
	/// </summary>
	[EnumMember(Value = "Private Access")]
	PrivateAccess
}
