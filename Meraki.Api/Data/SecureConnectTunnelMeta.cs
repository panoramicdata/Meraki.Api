namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelMeta
/// </summary>
[DataContract]
public class SecureConnectTunnelMeta
{
	/// <summary>
	/// The tunnel state information.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "state")]
	public SecureConnectTunnelMetaState State { get; set; } = new();
}
