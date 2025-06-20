namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDestination
/// </summary>
[DataContract]
public class SecureConnectDestination
{
	/// <summary>
	/// The comment about the destination.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// The date and time when the destination list was created.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// A domain, URL, or IP.
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destination")]
	public string Destination { get; set; } = string.Empty;

	/// <summary>
	/// The unique ID of the destination.
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The type of the destination. enum = ["domain", "url", "ipv4"]
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public SecureConnectDestinationListDestinationType Type { get; set; }
}
