namespace Meraki.Api.Data;

/// <summary>
/// Organizations Auth Radius Server Create Request
/// </summary>
[DataContract]
public class OrganizationsAuthRadiusServerCreateRequest
{
	/// <summary>
	/// The IP address or FQDN of the RADIUS server
	/// </summary>
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// The name of the RADIUS server
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Shared secret of the RADIUS server
	/// </summary>
	[DataMember(Name = "secret")]
	public string Secret { get; set; } = string.Empty;

	/// <summary>
	/// Available server modes
	/// </summary>
	[DataMember(Name = "modes")]
	public List<OrganizationsAuthRadiusServerMode>? Modes { get; set; }
}
