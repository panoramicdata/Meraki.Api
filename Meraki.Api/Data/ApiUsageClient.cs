namespace Meraki.Api.Data;

/// <summary>
/// An API usage client
/// </summary>
[DataContract]
public class ApiUsageClient
{
	/// <summary>
	/// ID for the client which made the request, if applicable.
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = null!;

	/// <summary>
	/// Type of client which made the request, if applicable.
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = null!;
}
