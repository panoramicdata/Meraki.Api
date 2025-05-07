using System;
using System.Net;

namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelClientMetaStateIpsec
/// </summary>
[DataContract]
public class SecureConnectTunnelMetaStateIpsec
{
	/// <summary>
	/// The age of the installed state in seconds.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "age")]
	public string Age { get; set; } = string.Empty;

	/// <summary>
	/// The ESP encryption algorithm name.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "encAlgo")]
	public string EncAlgo { get; set; } = string.Empty;

	/// <summary>
	/// The ESP encryption key size (optional field; not available with NULL encryption.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "encKeySize")]
	public string EncKeySize { get; set; } = string.Empty;

	/// <summary>
	/// The ESP or AH integrity algorithm name.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "integrityAlgo")]
	public string IntegrityAlgo { get; set; } = string.Empty;

	/// <summary>
	/// The hex encoded inbound SPI.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "spiIn")]
	public string SpiIn { get; set; } = string.Empty;

	/// <summary>
	/// The hex encoded outbound SPI.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "spiOut")]
	public string SpiOut { get; set; } = string.Empty;

	/// <summary>
	/// The peer traffic selectors.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "peerSelectors")]
	public List<string> PeerSelectors { get; set; } = [];
}
