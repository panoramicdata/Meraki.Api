using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// RadiusServer
/// </summary>
[DataContract]
public class SsidRadiusServer
{
	/// <summary>
	/// Public IP address of the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = null!;

	/// <summary>
	/// UDP port that the RADIUS server listens on for access requests
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "port")]
	public int Port { get; set; }

	/// <summary>
	/// RADIUS client shared secret
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "secret")]
	public string Secret { get; set; } = string.Empty;

	/// <summary>
	/// Certificate used for authorization for the RADSEC Server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "caCertificate")]
	public string CaCertificate { get; set; } = string.Empty;

	/// <summary>
	/// Use RADSEC (TLS over TCP) to connect to this RADIUS server. Requires radiusProxyEnabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radsecEnabled")]
	public bool RadsecEnabled { get; set; }
}
