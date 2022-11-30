namespace Meraki.Api.Data;

/// <summary>
/// User access devices
/// </summary>
[DataContract]
public class UserAccessDevices
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiKey]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// System type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "systemType")]
	public string SystemType { get; set; } = string.Empty;

	/// <summary>
	/// Mac
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Username
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "username")]
	public string Username { get; set; } = string.Empty;

	/// <summary>
	/// Email
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "email")]
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = new();

	/// <summary>
	/// Trusted access connections
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "trustedAccessConnections")]
	public List<TrustedAccessConnection> TrustedAccessConnections { get; set; } = new();
}
