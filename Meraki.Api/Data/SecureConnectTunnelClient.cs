using System.Net;

namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelClient
/// </summary>
[DataContract]
public class SecureConnectTunnelClient
{
	/// <summary>
	/// The type of device where the tunnel originates. The default value is other. enum = ["ASA", "FTD", "ISR", "Meraki MX", "Viptela cEdge", ...]
	/// Enum values list in the documentation does not appear to be exhaustive so this property is currenlty set to string.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "deviceType")]
	public string DeviceType { get; set; } = "other";

	/// <summary>
	/// The authentication context of the client.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authentication")]
	public SecureConnectTunnelClientAuthentication? Authentication { get; set; }
}
