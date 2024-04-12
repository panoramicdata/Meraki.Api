namespace Meraki.Api.Data;

/// <summary>
/// RadiusServer
/// </summary>
[DataContract]
public class RadiusServer
{
	/// <summary>
	/// Organization wide RADIUS server ID. This value will be empty if this RADIUS server is not an organization wide RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "organizationRadiusServerId")]
	public string? OrganizationRadiusServerId { get; set; }

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
	/// RADIUS client shared secret
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "secret")]
	public string? Secret { get; set; }
}
