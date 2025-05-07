using System;
using System.Net;

namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelClientMetaState
/// </summary>
[DataContract]
public class SecureConnectTunnelMetaState
{
	/// <summary>
	/// The domain name that is associate with the data center.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dc")]
	public string Dc { get; set; } = string.Empty;

	/// <summary>
	/// The city and country or region of the data center.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dcDesc")]
	public string DcDesc { get; set; } = string.Empty;

	/// <summary>
	/// The name of the data center.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dcName")]
	public string DcName { get; set; } = string.Empty;

	/// <summary>
	/// IKE SA State
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ikeState")]
	public string IkeState { get; set; } = string.Empty;

	/// <summary>
	/// IPSec/Child SA State
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipsecState")]
	public string IpsecState { get; set; } = string.Empty;

	/// <summary>
	/// The public IP address, which is assigned to an endpoint device (ISR, Viptela).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "localIp")]
	public string LocalIp { get; set; } = string.Empty;

	/// <summary>
	/// The date and time (UTC time with milliseconds) when the tunnel's state was last updated.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "modifiedAt")]
	public DateTime ModifiedAt { get; set; }

	/// <summary>
	/// The remote peer IKE ID.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "peerId")]
	public string PeerId { get; set; } = string.Empty;

	/// <summary>
	/// The remote peer IP.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "peerIp")]
	public string PeerIp { get; set; } = string.Empty;

	/// <summary>
	/// The port number of the remote peer.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "peerPort")]
	public string PeerPort { get; set; } = string.Empty;


	/// <summary>
	/// The high-level tunnel status: 
	/// up - the tunnel is active
	/// down - the tunnel is inactive
	/// failed - the tunnel is in a failed state
	/// unknown - the status is unknown and pending updated information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The tunnel ID.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tunnelId")]
	public string TunnelId { get; set; } = string.Empty;

	/// <summary>
	/// The state of the tunnel's data plane.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "data")]
	public SecureConnectTunnelMetaStateData Data { get; set; } = new();

	/// <summary>
	/// The tunnel IKE session state.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ike")]
	public SecureConnectTunnelMetaStateIke Ike { get; set; } = new();

	/// <summary>
	/// The tunnel IPsec session state.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipsec")]
	public SecureConnectTunnelMetaStateIpsec Ipsec { get; set; } = new();
}
