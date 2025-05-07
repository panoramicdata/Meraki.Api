using System;
using System.Net;

namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelClientMetaStateIke
/// </summary>
[DataContract]
public class SecureConnectTunnelMetaStateIke
{
	/// <summary>
	/// The age of the established state in seconds.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "age")]
	public string Age { get; set; } = string.Empty;

	/// <summary>
	/// The IKE Diffie-Hellman group.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhGroup")]
	public string DhGroup { get; set; } = string.Empty;

	/// <summary>
	/// The IKE encryption algorithm.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "encAlgo")]
	public string EncAlgo { get; set; } = string.Empty;

	/// <summary>
	/// The hex encoded initiator SPI or cookie.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "initiatorSpi")]
	public string InitiatorSpi { get; set; } = string.Empty;

	/// <summary>
	/// The IKE pseudo random function.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "prfAlgo")]
	public string PrfAlgo { get; set; } = string.Empty;

	/// <summary>
	/// The hex encoded responder SPI or cookie.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "responderSpi")]
	public string ResponderSpi { get; set; } = string.Empty;
}
