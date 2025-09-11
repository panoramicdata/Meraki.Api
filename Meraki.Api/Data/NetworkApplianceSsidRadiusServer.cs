namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceSsidRadiusServer
/// </summary>
[DataContract]
public class NetworkApplianceSsidRadiusServer
{
	/// <summary>
	/// Public IP address of the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "host")]
	public string? Host { get; set; }

	/// <summary>
	/// UDP port that the RADIUS server listens on for access requests
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "port")]
	public int? Port { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? RadiusServerId { get; set; }

	/// <summary>
	/// Undocumented openRoamingCertificateId (always observed as null so far)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "openRoamingCertificateId")]
	public long? OpenRoamingCertificateId { get; set; }

	/// <summary>
	/// Undocumented caCertificate (always observed as null so far)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "caCertificate")]
	public object? CaCertificate { get; set; }
}
