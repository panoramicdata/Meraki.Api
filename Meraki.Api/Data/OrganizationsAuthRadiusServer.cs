namespace Meraki.Api.Data;

/// <summary>
/// Organizations Auth Radius Server
/// </summary>
[DataContract]
public class OrganizationsAuthRadiusServer
{
	/// <summary>
	/// The IP address or FQDN of the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// The name of the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The id of the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serverId")]
	public string? ServerId { get; set; }

	/// <summary>
	/// Available server modes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "modes")]
	public List<OrganizationsAuthRadiusServerMode>? Modes { get; set; }
}
