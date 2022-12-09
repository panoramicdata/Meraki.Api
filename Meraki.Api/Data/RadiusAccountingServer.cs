namespace Meraki.Api.Data;

/// <summary>
/// RadiusAccountingServer
/// </summary>
[DataContract]
public class RadiusAccountingServer
{
	/// <summary>
	/// The Id - not used for anything
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// IP address to which the APs will send RADIUS accounting messages
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = null!;

	/// <summary>
	/// Port on the RADIUS server that is listening for accounting messages
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "port")]
	public int? Port { get; set; }

	/// <summary>
	/// Shared key used to authenticate messages between the APs and RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "secret")]
	public string Secret { get; set; } = null!;

	/// <summary>
	/// Radsec enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radsecEnabled")]
	public bool? RadsecEnabled { get; set; }

	/// <summary>
	/// Undocumented openRoamingCertificateId (always observed as null so far)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "openRoamingCertificateId")]
	public object? OpenRoamingCertificateId { get; set; }

	/// <summary>
	/// Undocumented caCertificate (always observed as null so far)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "caCertificate")]
	public object? CaCertificate { get; set; }
}
