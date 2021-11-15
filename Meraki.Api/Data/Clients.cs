namespace Meraki.Api.Data;

[DataContract]
public class Clients
{
	/// <summary>
	/// The MAC address of the client
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The display name for the client.
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
