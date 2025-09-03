namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectionDestinationCreateRequest
/// </summary>
[DataContract]
public class SecureConnectionDestinationCreateRequest
{
	/// <summary>
	/// A comment about the destination.
	/// </summary>
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// A domain, URL, or IP.
	/// </summary>
	[DataMember(Name = "destination")]
	public string Destination { get; set; } = string.Empty;
}
