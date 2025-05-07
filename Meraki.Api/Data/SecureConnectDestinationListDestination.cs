namespace Meraki.Api.Data;

/// <summary>
/// A destination
/// </summary>

[DataContract]
public class SecureConnectDestinationListDestination
{
	/// <summary>
	/// The comment about the destination.
	/// </summary>
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// A domain, URL, or IP.
	/// </summary>
	[DataMember(Name = "destination")]
	public string? Destination { get; set; }

	/// <summary>
	/// The type of the destination. enum = ["domain", "url", "ipv4"]
	/// </summary>
	[DataMember(Name = "type")]
	public SecureConnectDestinationListDestinationType? Type { get; set; }
}
