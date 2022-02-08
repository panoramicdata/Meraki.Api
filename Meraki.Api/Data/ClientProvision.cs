namespace Meraki.Api.Data;

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
}
