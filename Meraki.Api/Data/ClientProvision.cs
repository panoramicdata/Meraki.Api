namespace Meraki.Api.Data;

/// <summary>
/// Client Provision
/// </summary>
[DataContract]
public class ClientProvision
{
	/// <summary>
	/// The MAC address of the client
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The display name for the client.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The identifier of the client
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientId")]
	public string? ClientId { get; set; }

	/// <summary>
	/// The client's display message if its group policy is 'Blocked'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "message")]
	public string? Message { get; set; }
}
