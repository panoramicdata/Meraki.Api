﻿namespace Meraki.Api.Data;

/// <summary>
/// RadiusServer
/// </summary>
[DataContract]
public class SsidRadiusServer
{
	/// <summary>
	/// The Id - not used for anything
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The ID of the Openroaming Certificate attached to radius server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "openRoamingCertificateId")]
	public long? OpenRoamingCertificateId { get; set; }

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
	/// The API doesn't return Secret, but it can be set
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
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

	/// <inheritdoc />
	public override string ToString()
		=> $"{Host}:{Port}:{Secret}";
}
