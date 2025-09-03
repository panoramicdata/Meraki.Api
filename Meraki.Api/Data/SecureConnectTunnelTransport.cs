using System.Net;

namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelTransport
/// </summary>
[DataContract]
public class SecureConnectTunnelTransport
{
	/// <summary>
	/// The tunnel transport protocol. The default is IPSec. enum = ["IPSec"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string? Protocol { get; set; } = string.Empty;
}
