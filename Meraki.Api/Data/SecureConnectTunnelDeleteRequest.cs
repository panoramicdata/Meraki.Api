namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelDeleteRequest
/// </summary>
[DataContract]
public class SecureConnectTunnelDeleteRequest
{
	/// <summary>
	/// Specifies whether to detach associated policies from the tunnel. default = true
	/// </summary>
	[DataMember(Name = "detachPolicies")]
	public bool? DetachPolicies { get; set; }
}
